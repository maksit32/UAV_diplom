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
		private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"������ ��������� ��������� ����������� ��������� ������ ��-6 ���������� ���" +
							$"{Environment.NewLine}����������� �������� ������������{Environment.NewLine}{Environment.NewLine}" +
							$"����� ��� �����:  kornilovmaks2001111@mail.ru", "�� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"������ ��������� ��������� ��������� ���������� ���������� � ���������� ����������� ������ �����������." +
				$"{Environment.NewLine}{Environment.NewLine}" +
				$"�������� ������ ���������:{Environment.NewLine}" +
				$"1) ��������{Environment.NewLine}" +
				$"2) ������������{Environment.NewLine}" +
				$"3) ������ � ����������{Environment.NewLine}", "� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				// ���� ��� ����� ��� ����������� ������, �������� ����
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

				//������� �� ��������� ���������
				ChoiceModeForm form = new ChoiceModeForm(user);

				this.Hide();
				form.Show();
			}
			catch (Exception)
			{
				MessageBox.Show($"������� ���������� ���! ��� �� ����� ���� ������!",
					"��������, ������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}