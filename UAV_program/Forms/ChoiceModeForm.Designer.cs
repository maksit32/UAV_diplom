namespace UAV_program.Forms
{
	partial class ChoiceModeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceModeForm));
			menuStrip1 = new MenuStrip();
			обАвтореToolStripMenuItem = new ToolStripMenuItem();
			оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			label1 = new Label();
			groupBox1 = new GroupBox();
			button2 = new Button();
			button1 = new Button();
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
			menuStrip1.Size = new Size(1230, 39);
			menuStrip1.TabIndex = 1;
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(287, 71);
			label1.Name = "label1";
			label1.Size = new Size(238, 38);
			label1.TabIndex = 4;
			label1.Text = "Выберите режим";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.AliceBlue;
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(button1);
			groupBox1.Location = new Point(222, 127);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(824, 277);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Поле выбора режима";
			// 
			// button2
			// 
			button2.BackColor = Color.AntiqueWhite;
			button2.Location = new Point(515, 161);
			button2.Name = "button2";
			button2.Size = new Size(251, 60);
			button2.TabIndex = 5;
			button2.Text = "Без базы данных";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.AntiqueWhite;
			button1.Location = new Point(57, 161);
			button1.Name = "button1";
			button1.Size = new Size(242, 60);
			button1.TabIndex = 1;
			button1.Text = "С базой данных";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// ChoiceModeForm
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1230, 503);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ChoiceModeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добро пожаловать в программу!";
			FormClosing += ChoiceModeForm_FormClosing;
			Load += ChoiceModeForm_Load;
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
		private Label label1;
		private GroupBox groupBox1;
		private Button button1;
		private Button button2;
	}
}