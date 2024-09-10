namespace PersonalHotel
{
	partial class JobHistoryDialog
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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			textBox2 = new TextBox();
			button2 = new Button();
			label2 = new Label();
			monthCalendar1 = new MonthCalendar();
			label3 = new Label();
			checkBox1 = new CheckBox();
			monthCalendar2 = new MonthCalendar();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 0;
			label1.Text = "Employee";
			// 
			// textBox1
			// 
			textBox1.Enabled = false;
			textBox1.Location = new Point(77, 6);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(286, 23);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(369, 6);
			button1.Name = "button1";
			button1.Size = new Size(139, 23);
			button1.TabIndex = 2;
			button1.Text = "Select employee";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(77, 35);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(286, 23);
			textBox2.TabIndex = 3;
			// 
			// button2
			// 
			button2.Location = new Point(369, 35);
			button2.Name = "button2";
			button2.Size = new Size(139, 23);
			button2.TabIndex = 4;
			button2.Text = "Select job";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(46, 39);
			label2.Name = "label2";
			label2.Size = new Size(25, 15);
			label2.TabIndex = 5;
			label2.Text = "Job";
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(18, 95);
			monthCalendar1.MaxSelectionCount = 1;
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(18, 71);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 7;
			label3.Text = "Start date";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(254, 71);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(72, 19);
			checkBox1.TabIndex = 8;
			checkBox1.Text = "End date";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// monthCalendar2
			// 
			monthCalendar2.Location = new Point(263, 95);
			monthCalendar2.Name = "monthCalendar2";
			monthCalendar2.TabIndex = 9;
			// 
			// button3
			// 
			button3.Location = new Point(433, 269);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 10;
			button3.Text = "OK";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(18, 269);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 11;
			button4.Text = "Cancel";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// JobHistoryDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(526, 310);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(monthCalendar2);
			Controls.Add(checkBox1);
			Controls.Add(label3);
			Controls.Add(monthCalendar1);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "JobHistoryDialog";
			Text = "Create job entry";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private TextBox textBox2;
		private Button button2;
		private Label label2;
		private MonthCalendar monthCalendar1;
		private Label label3;
		private CheckBox checkBox1;
		private MonthCalendar monthCalendar2;
		private Button button3;
		private Button button4;
	}
}