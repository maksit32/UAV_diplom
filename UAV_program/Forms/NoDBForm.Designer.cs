﻿namespace UAV_program.Forms
{
	partial class NoDBForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoDBForm));
			оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			обАвтореToolStripMenuItem = new ToolStripMenuItem();
			groupBox1 = new GroupBox();
			NextButton = new Button();
			PrevButton = new Button();
			richTextBox1 = new RichTextBox();
			pictureBox1 = new PictureBox();
			ModeLabel = new Label();
			NameLabel = new Label();
			label1 = new Label();
			comboBox1 = new ComboBox();
			timer1 = new System.Windows.Forms.Timer(components);
			groupBox2 = new GroupBox();
			TimerLabel = new Label();
			AnswerTextBox = new TextBox();
			Start_EnterTestButton = new Button();
			AnswersRichTextBox = new RichTextBox();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// оПрограммеToolStripMenuItem
			// 
			оПрограммеToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			оПрограммеToolStripMenuItem.Size = new Size(170, 35);
			оПрограммеToolStripMenuItem.Text = "О программе";
			оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { обАвтореToolStripMenuItem, оПрограммеToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1300, 39);
			menuStrip1.TabIndex = 3;
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
			// groupBox1
			// 
			groupBox1.BackColor = Color.PowderBlue;
			groupBox1.Controls.Add(NextButton);
			groupBox1.Controls.Add(PrevButton);
			groupBox1.Controls.Add(richTextBox1);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Location = new Point(117, 259);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1067, 459);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Обучающий блок";
			// 
			// NextButton
			// 
			NextButton.Location = new Point(597, 371);
			NextButton.Name = "NextButton";
			NextButton.Size = new Size(309, 59);
			NextButton.TabIndex = 5;
			NextButton.Text = "Далее";
			NextButton.UseVisualStyleBackColor = true;
			NextButton.Click += NextButton_Click;
			// 
			// PrevButton
			// 
			PrevButton.Location = new Point(67, 371);
			PrevButton.Name = "PrevButton";
			PrevButton.Size = new Size(309, 59);
			PrevButton.TabIndex = 4;
			PrevButton.Text = "Назад";
			PrevButton.UseVisualStyleBackColor = true;
			PrevButton.Click += PrevButton_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = SystemColors.Menu;
			richTextBox1.Location = new Point(440, 54);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new Size(603, 287);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "Текст";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(26, 54);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(398, 287);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// ModeLabel
			// 
			ModeLabel.AutoSize = true;
			ModeLabel.Location = new Point(827, 186);
			ModeLabel.Name = "ModeLabel";
			ModeLabel.Size = new Size(196, 31);
			ModeLabel.TabIndex = 9;
			ModeLabel.Text = "Режим: обучение";
			ModeLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Location = new Point(827, 123);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(127, 31);
			NameLabel.TabIndex = 8;
			NameLabel.Text = "Ваше имя: ";
			NameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(117, 66);
			label1.Name = "label1";
			label1.Size = new Size(199, 31);
			label1.TabIndex = 12;
			label1.Text = "Выберите режим:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			comboBox1.DisplayMember = "0";
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Обучение", "Тестирование", "Литература" });
			comboBox1.Location = new Point(117, 123);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(502, 39);
			comboBox1.TabIndex = 11;
			comboBox1.ValueMember = "0";
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Azure;
			groupBox2.Controls.Add(TimerLabel);
			groupBox2.Controls.Add(AnswerTextBox);
			groupBox2.Controls.Add(Start_EnterTestButton);
			groupBox2.Controls.Add(AnswersRichTextBox);
			groupBox2.Location = new Point(117, 257);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1067, 499);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Тестирование";
			// 
			// TimerLabel
			// 
			TimerLabel.AutoSize = true;
			TimerLabel.Location = new Point(26, 34);
			TimerLabel.Name = "TimerLabel";
			TimerLabel.Size = new Size(86, 31);
			TimerLabel.TabIndex = 8;
			TimerLabel.Text = "Время:";
			// 
			// AnswerTextBox
			// 
			AnswerTextBox.Location = new Point(393, 380);
			AnswerTextBox.Name = "AnswerTextBox";
			AnswerTextBox.Size = new Size(309, 38);
			AnswerTextBox.TabIndex = 4;
			AnswerTextBox.TextAlign = HorizontalAlignment.Center;
			AnswerTextBox.Visible = false;
			AnswerTextBox.KeyPress += AnswerTextBox_KeyPress;
			// 
			// Start_EnterTestButton
			// 
			Start_EnterTestButton.Location = new Point(393, 424);
			Start_EnterTestButton.Name = "Start_EnterTestButton";
			Start_EnterTestButton.Size = new Size(309, 59);
			Start_EnterTestButton.TabIndex = 3;
			Start_EnterTestButton.Text = "Начать тест";
			Start_EnterTestButton.UseVisualStyleBackColor = true;
			Start_EnterTestButton.Click += Start_EnterTestButton_Click;
			// 
			// AnswersRichTextBox
			// 
			AnswersRichTextBox.BackColor = SystemColors.Menu;
			AnswersRichTextBox.Location = new Point(26, 70);
			AnswersRichTextBox.Name = "AnswersRichTextBox";
			AnswersRichTextBox.ReadOnly = true;
			AnswersRichTextBox.Size = new Size(1016, 291);
			AnswersRichTextBox.TabIndex = 1;
			AnswersRichTextBox.Text = "Текст";
			// 
			// NoDBForm
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1300, 768);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(ModeLabel);
			Controls.Add(NameLabel);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5);
			MaximizeBox = false;
			MaximumSize = new Size(1318, 815);
			MinimizeBox = false;
			MinimumSize = new Size(1318, 815);
			Name = "NoDBForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Обучающая программа в режиме отсутствия взаимодействия с БД";
			FormClosing += NoDBForm_FormClosing;
			Load += NoDBForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStripMenuItem оПрограммеToolStripMenuItem;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem обАвтореToolStripMenuItem;
		private GroupBox groupBox1;
		private RichTextBox richTextBox1;
		private PictureBox pictureBox1;
		private Label ModeLabel;
		private Label NameLabel;
		private Label label1;
		private ComboBox comboBox1;
		private Button NextButton;
		private Button PrevButton;
		private System.Windows.Forms.Timer timer1;
		private GroupBox groupBox2;
		private Label TimerLabel;
		private TextBox AnswerTextBox;
		private Button Start_EnterTestButton;
		private RichTextBox AnswersRichTextBox;
	}
}