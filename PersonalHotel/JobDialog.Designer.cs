namespace PersonalHotel
{
	partial class JobDialog
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
			numericUpDown1 = new NumericUpDown();
			label2 = new Label();
			label3 = new Label();
			numericUpDown2 = new NumericUpDown();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 0;
			label1.Text = "Title";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(47, 6);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(255, 23);
			textBox1.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(114, 35);
			numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(188, 23);
			numericUpDown1.TabIndex = 2;
			numericUpDown1.Value = new decimal(new int[] { 3000, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 37);
			label2.Name = "label2";
			label2.Size = new Size(96, 15);
			label2.TabIndex = 3;
			label2.Text = "Miniimum salary";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(13, 66);
			label3.Name = "label3";
			label3.Size = new Size(95, 15);
			label3.TabIndex = 4;
			label3.Text = "Maximum salary";
			// 
			// numericUpDown2
			// 
			numericUpDown2.Location = new Point(113, 64);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(189, 23);
			numericUpDown2.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(227, 104);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 6;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(13, 104);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 7;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// JobDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(315, 159);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(numericUpDown2);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(numericUpDown1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "JobDialog";
			Text = "Add new job";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private Label label2;
		private Label label3;
		private NumericUpDown numericUpDown2;
		private Button button1;
		private Button button2;
	}
}