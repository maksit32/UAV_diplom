namespace UAV_program
{
	partial class EnterForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
			menuStrip1 = new MenuStrip();
			обАвтореToolStripMenuItem = new ToolStripMenuItem();
			оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			groupBox1 = new GroupBox();
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { обАвтореToolStripMenuItem, оПрограммеToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1254, 39);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// обАвтореToolStripMenuItem
			// 
			обАвтореToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
			обАвтореToolStripMenuItem.Size = new Size(136, 35);
			обАвтореToolStripMenuItem.Text = "Об авторе";
			обАвтореToolStripMenuItem.Click += обАвтореToolStripMenuItem_Click;
			// 
			// оПрограммеToolStripMenuItem
			// 
			оПрограммеToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			оПрограммеToolStripMenuItem.Size = new Size(170, 35);
			оПрограммеToolStripMenuItem.Text = "О программе";
			оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.AliceBlue;
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(353, 205);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(563, 230);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Введите ваше имя";
			// 
			// button1
			// 
			button1.BackColor = Color.AntiqueWhite;
			button1.Location = new Point(116, 155);
			button1.Name = "button1";
			button1.Size = new Size(345, 41);
			button1.TabIndex = 1;
			button1.Text = "Ввести данные";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(116, 80);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(345, 38);
			textBox1.TabIndex = 0;
			textBox1.TextAlign = HorizontalAlignment.Center;
			textBox1.KeyPress += textBox1_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(334, 141);
			label1.Name = "label1";
			label1.Size = new Size(609, 38);
			label1.TabIndex = 2;
			label1.Text = "Добро пожаловать в обучающую программу!";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// EnterForm
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1254, 558);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Margin = new Padding(5);
			MaximizeBox = false;
			MaximumSize = new Size(1272, 605);
			MinimizeBox = false;
			MinimumSize = new Size(1272, 605);
			Name = "EnterForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добро пожаловать в программу!";
			Load += Form1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem обАвтореToolStripMenuItem;
		private ToolStripMenuItem оПрограммеToolStripMenuItem;
		private GroupBox groupBox1;
		private Label label1;
		private TextBox textBox1;
		private Button button1;
	}
}
