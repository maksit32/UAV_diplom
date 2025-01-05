using Microsoft.Extensions.Configuration;
using UAV_program.DbContexts;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Exceptions;
using UAV_program.Domain.Services.Interfaces;
using UAV_program.Forms;
using UAV_program.Services;

namespace UAV_program
{
	public partial class EnterForm : Form
	{
		#region [Objects]
		//objects
		private User user;

		//services
		private readonly IValidationService validationService = new ValidationService();
		#endregion

		public EnterForm()
		{
			InitializeComponent();
		}

		#region [Methods]
		private void Form1_Load(object sender, EventArgs e)
		{

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

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				// Если это цифра или специальный символ, отменяем ввод
				e.Handled = true;
			}
			if(this.textBox1.Text.Length > 15 ) 
			{
				e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				user = new User(this.textBox1.Text);
				validationService.ValidateUser(user);

				//переход на следующий мнемокадр
				ChoiceModeForm form = new ChoiceModeForm(user);

				this.Hide();
				form.Show();
			}
			catch (Exception)
			{
				MessageBox.Show($"Введите корректное имя! Имя не может быть пустым!",
					"Внимание, ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}