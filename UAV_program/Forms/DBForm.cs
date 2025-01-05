using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using static UAV_program.Domain.Constants.Filepaths;

namespace UAV_program.Forms
{
	public partial class DBForm : Form
	{
		#region [Objects]
		//objects
		private int indexBtn = 0;
		private int timeElapsed = 0; // Время прошло в секундах
		private const int duration = 600; // 10 минут в секундах
		private bool isMessageBoxShown = false; // Флаг для отслеживания состояния
		private bool isExam = false;
		private int questionIndex = 0;

		private User user;
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
			if (!isMessageBoxShown)
			{
				isMessageBoxShown = true;
				MessageBox.Show($"Спасибо за пользование программой!", "Выход из программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Application.Exit();
		}

		private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Данная обучающая программа разработана студентом группы РС-6 факультета АСК" +
							$"{Environment.NewLine}Корнильевым Максимом Михайловичем{Environment.NewLine}{Environment.NewLine}" +
							$"Почта для связи:  kornilovmaks2001111@mail.ru", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			indexBtn--;
			var pair = theoryService.MoveTheoryIndex(ref indexBtn, false);
			this.pictureBox1.Image = Image.FromFile(pair.Key);
			this.richTextBox1.Text = pair.Value;
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			indexBtn++;
			var pair = theoryService.MoveTheoryIndex(ref indexBtn, true);
			this.pictureBox1.Image = Image.FromFile(pair.Key);
			this.richTextBox1.Text = pair.Value;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				//обучение
				case 0:
					{
						this.ModeLabel.Text = "Режим: обучение";
						this.groupBox1.Visible = true;
						this.groupBox2.Visible = false;

						indexBtn = 0;
						var pair = theoryService.MoveTheoryIndex(ref indexBtn, true);
						this.pictureBox1.Image = Image.FromFile(pair.Key);
						this.richTextBox1.Text = pair.Value;
					}
					break;
				//тест
				case 1:
					{
						this.ModeLabel.Text = "Режим: тест";
						this.groupBox2.Visible = true;
						this.groupBox1.Visible = false;

						//выдача теста
						this.lstIndexes = new List<int>();
						this.lstAnswers = testService.GenerateTest();
						this.AnswersRichTextBox.Text = $"В тесте содержится 10 вопросов с 4 вариантами ответов.{Environment.NewLine}" +
							$"Для ввода ответа напишите цифру в поле ниже и нажмите кнопку ВВОД";
					}
					break;
				//литература
				case 2:
					{
						this.ModeLabel.Text = "Режим: литература";
						this.groupBox1.Visible = true;
						this.groupBox2.Visible = false;

						indexBtn = 0;
						var pair = theoryService.MoveTheoryIndex(ref indexBtn, true);
						this.pictureBox1.Image = Image.FromFile(pair.Key);
						this.richTextBox1.Text = pair.Value;

						//открытие папки с литературой
						Process.Start("explorer.exe", literaturePath);
					}
					break;
			}
		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				timeElapsed++;
				this.TimerLabel.Text = "Секунд осталось: " + (duration - timeElapsed).ToString();

				//время закончилось
				if (timeElapsed >= duration)
				{
					// Останавливаем таймер
					timer1.Stop();
					//подсчет результатов
					Test testRes = testService.CreateDbTest(lstAnswers, lstIndexes, user);
					//выводим сообщение о завершении теста
					MessageBox.Show($"Внимание, время тестирования закончилось!{Environment.NewLine}" +
						$"{Environment.NewLine}Спасибо за пользование программой", "Тест окончен", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

		private void AnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; //Отменяем ввод, если символ не цифра и не Backspace
				return;
			}
		}

		private async void Start_EnterTestButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!isExam)
				{
					MessageBox.Show("Экзамен начат!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
					isExam = true;
					this.AnswerTextBox.Visible = true;
					var qstn = lstAnswers[questionIndex];
					this.AnswersRichTextBox.Text = qstn.ToString();
					this.Start_EnterTestButton.Text = "ВВОД";
					timer1.Start();
				}
				//проведение экзамена
				else
				{
					if (string.IsNullOrWhiteSpace(this.AnswerTextBox.Text)) return;
					questionIndex++;
					//проверка на выполненный тест
					if (questionIndex == 10)
					{
						lstIndexes.Add(Convert.ToInt32(this.AnswerTextBox.Text) - 1);
						this.AnswerTextBox.Text = "";
						timer1.Stop();
						//подсчет результатов
						Test testRes = testService.CreateDbTest(lstAnswers, lstIndexes, user);
						//выводим сообщение о завершении теста
						MessageBox.Show($"Тест выполнен!{Environment.NewLine}" +
							$"{Environment.NewLine}Спасибо за пользование программой", "Тест окончен", MessageBoxButtons.OK, MessageBoxIcon.Information);

						//запись в бд результата экзамена
						using TestDbContext dbContext = new TestDbContext(connectionString);
						ITestRepository testRepo = new TestRepository(dbContext);
						await testRepo.AddTestAsync(testRes, cts.Token);
						//выход из программы
						Application.Exit();
					};

					lstIndexes.Add(Convert.ToInt32(this.AnswerTextBox.Text) - 1);
					this.AnswerTextBox.Text = "";
					//выдача вопроса
					var qstn = lstAnswers[questionIndex];
					this.AnswersRichTextBox.Text = qstn.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Возникла ошибка при прохождении теста!{ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
		#endregion
	}
}
