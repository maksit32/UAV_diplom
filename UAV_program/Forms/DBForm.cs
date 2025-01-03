using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAV_program.DbContexts;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Exceptions;
using UAV_program.Domain.Repository.Interfaces;
using UAV_program.Domain.Services.Interfaces;
using UAV_program.Repository;
using UAV_program.Services;

namespace UAV_program.Forms
{
	public partial class DBForm : Form
	{
		#region [Objects]
		//filepaths
		private static readonly string appSettingsPath = Environment.CurrentDirectory + "\\..\\..\\..\\Settings\\appsettings.json";

		//objects
		private User user;
		private int indexBtn = 0;
		private int timeElapsed = 0; // Время прошло в секундах
		private const int duration = 600; // 10 минут в секундах
		private List<Answer> lstAnswers;
		private List<int> lstIndexes;

		//configurations
		private static readonly IConfiguration configuration = new ConfigurationBuilder()
			.AddJsonFile(appSettingsPath, optional: true, reloadOnChange: true)
			.Build();

		//connection string
		private static readonly string connectionString = configuration.GetConnectionString("PostgreSqlConnectionString")
						?? throw new EmptyConnectionStringException("Connection string not found.");

		//services
		private readonly ITheoryService theoryService = new TheoryService();
		private readonly ITestService testService = new TestService();

		//CTS
		private static readonly CancellationTokenSource cts = new CancellationTokenSource();
		#endregion

		public DBForm(User user)
		{
			InitializeComponent();
			this.user = user;
		}

		#region [Methods]
		private void DBForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Данная обучающая программа разработана студентом группы РС-6 факультета АСК" +
							$"{Environment.NewLine}Корнильевым Максимом Михайловичем", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Данная обучающая программа позволяет ознакомить операторов с комплексом мониторинга земной поверхности." +
										$"{Environment.NewLine}{Environment.NewLine}" +
										$"Основные режимы программы:{Environment.NewLine}" +
										$"1) Обучение{Environment.NewLine}" +
										$"2) Тестирование{Environment.NewLine}" +
										$"3) Доступ к литературе{Environment.NewLine}", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void DBForm_Load(object sender, EventArgs e)
		{
			this.NameLabel.Text = user.ToString();
			this.comboBox1.SelectedIndex = 0;
		}

		//режим обучение
		private void PrevButton_Click(object sender, EventArgs e)
		{
			var pair = theoryService.MoveTheoryIndex(ref indexBtn, false);
			this.pictureBox1.Image = Image.FromFile(pair.Key);
			this.richTextBox1.Text = pair.Value;
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			var pair = theoryService.MoveTheoryIndex(ref indexBtn, true);
			this.pictureBox1.Image = Image.FromFile(pair.Key);
			this.richTextBox1.Text = pair.Value;
		}
		//режим теста

		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				//обучение
				case 0:
					{
						this.ModeLabel.Text = "Режим: обучение";
						this.groupBox1.Visible = true;
					}
					break;
				//тест
				case 1:
					{
						this.ModeLabel.Text = "Режим: тест";
						this.groupBox1.Visible = false;
					}
					break;
				//литература
				case 2:
					{
						this.ModeLabel.Text = "Режим: литература";
						this.groupBox1.Visible = false;
					}
					break;
				default:
					break;
			}
		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				timeElapsed++;

				//время закончилось
				if (timeElapsed >= duration)
				{
					// Останавливаем таймер
					timer1.Stop();
					//подсчет результатов
					Test testRes = testService.CreateDbTest(lstAnswers, lstIndexes, user);
					//выводим сообщение о завершении теста
					MessageBox.Show($"Внимание, время тестирования закончилось!", "Тест окончен", MessageBoxButtons.OK, MessageBoxIcon.Information);

					//запись в бд результата экзамена
					using TestDbContext dbContext = new TestDbContext(connectionString);
					ITestRepository testRepo = new TestRepository(dbContext);
					await testRepo.AddTestAsync(testRes, cts.Token);
					//выход из программы
					Application.Exit();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Возникла ошибка при прохождении теста!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
