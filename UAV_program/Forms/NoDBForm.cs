using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAV_program.Domain.Entities;

namespace UAV_program.Forms
{
	public partial class NoDBForm : Form
	{
		#region [Objects]
		//filepaths
		private static readonly string _literatureFP = Environment.CurrentDirectory + "\\..\\..\\..\\Literature\\";
		private static readonly string _resultsFP = Environment.CurrentDirectory + "\\..\\..\\..\\Results\\";


		//objects
		private User user;

		//CTS
		private static readonly CancellationTokenSource cts = new CancellationTokenSource();
		#endregion

		public NoDBForm(User user)
		{
			InitializeComponent();
			this.user = user;
		}

		#region [Methods]
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

		private void NoDBForm_Load(object sender, EventArgs e)
		{

		}
		#endregion

		private void NoDBForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
