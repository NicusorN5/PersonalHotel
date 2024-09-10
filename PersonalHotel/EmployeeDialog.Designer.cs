namespace PersonalHotel
{
	partial class EmployeeDialog
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
			tbFirstName = new TextBox();
			tbLastName = new TextBox();
			label2 = new Label();
			monthCalendar1 = new MonthCalendar();
			label3 = new Label();
			label4 = new Label();
			numericUpDown1 = new NumericUpDown();
			label5 = new Label();
			tbPhone = new TextBox();
			label6 = new Label();
			tbEmail = new TextBox();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 0;
			label1.Text = "First name";
			// 
			// tbFirstName
			// 
			tbFirstName.Location = new Point(80, 6);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new Size(197, 23);
			tbFirstName.TabIndex = 1;
			// 
			// tbLastName
			// 
			tbLastName.Location = new Point(80, 35);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new Size(197, 23);
			tbLastName.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 38);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 3;
			label2.Text = "Last name";
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(18, 91);
			monthCalendar1.MaxSelectionCount = 1;
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 67);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 5;
			label3.Text = "Birth date";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 262);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 6;
			label4.Text = "Salary";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(56, 260);
			numericUpDown1.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(221, 23);
			numericUpDown1.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 291);
			label5.Name = "label5";
			label5.Size = new Size(41, 15);
			label5.TabIndex = 8;
			label5.Text = "Phone";
			// 
			// tbPhone
			// 
			tbPhone.Location = new Point(59, 288);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(218, 23);
			tbPhone.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(15, 319);
			label6.Name = "label6";
			label6.Size = new Size(41, 15);
			label6.TabIndex = 10;
			label6.Text = "E-mail";
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(59, 317);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(218, 23);
			tbEmail.TabIndex = 11;
			// 
			// button1
			// 
			button1.Location = new Point(202, 346);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 12;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(12, 346);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 13;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// EmployeeDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(300, 386);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(tbEmail);
			Controls.Add(label6);
			Controls.Add(tbPhone);
			Controls.Add(label5);
			Controls.Add(numericUpDown1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(monthCalendar1);
			Controls.Add(label2);
			Controls.Add(tbLastName);
			Controls.Add(tbFirstName);
			Controls.Add(label1);
			Name = "EmployeeDialog";
			Text = "Add new employee";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbFirstName;
		private TextBox tbLastName;
		private Label label2;
		private MonthCalendar monthCalendar1;
		private Label label3;
		private Label label4;
		private NumericUpDown numericUpDown1;
		private Label label5;
		private TextBox tbPhone;
		private Label label6;
		private TextBox tbEmail;
		private Button button1;
		private Button button2;
	}
}