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
	public partial class ChoiceModeForm : Form
	{
		#region [Objects]
		//filepaths
		private static readonly string appSettingsPath = Environment.CurrentDirectory + "\\..\\..\\..\\Settings\\appsettings.json";

		//objects
		private User user;

		//configurations
		private static readonly IConfiguration configuration = new ConfigurationBuilder()
			.AddJsonFile(appSettingsPath, optional: true, reloadOnChange: true)
			.Build();

		//connection string
		private static readonly string connectionString = configuration.GetConnectionString("PostgreSqlConnectionString")
						?? throw new EmptyConnectionStringException("Connection string not found.");

		//CTS
		private static readonly CancellationTokenSource cts = new CancellationTokenSource();
		#endregion

		public ChoiceModeForm(User user)
		{
			InitializeComponent();
			this.user = user;
		}

		#region [Methods]
		private void ChoiceModeForm_Load(object sender, EventArgs e)
		{

		}

		private void ChoiceModeForm_FormClosing(object sender, FormClosingEventArgs e)
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

		//с БД
		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using TestDbContext dbContext = new TestDbContext(connectionString);
				IUserRepository userRepo = new UserRepository(dbContext);
				await userRepo.AddUserAsync(user, cts.Token);

				//переход на следующий мнемокадр
				DBForm form = new DBForm(user);

				this.Hide();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при работе с БД! {Environment.NewLine}{ex.Message}",
					"Внимание, ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//без БД
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				NoDBForm form = new NoDBForm();
				//переход на следующий мнемокадр

				this.Hide();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при открытии страницы! {Environment.NewLine}{ex.Message}",
					"Внимание, ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}
