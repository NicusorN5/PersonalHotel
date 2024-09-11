namespace PersonalHotel
{
	partial class SelectEmployeeDialog
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
			employeesList = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			SuspendLayout();
			// 
			// employeesList
			// 
			employeesList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader11 });
			employeesList.Dock = DockStyle.Fill;
			employeesList.FullRowSelect = true;
			employeesList.Location = new Point(0, 0);
			employeesList.MultiSelect = false;
			employeesList.Name = "employeesList";
			employeesList.Size = new Size(612, 411);
			employeesList.TabIndex = 1;
			employeesList.UseCompatibleStateImageBehavior = false;
			employeesList.View = View.Details;
			employeesList.MouseDoubleClick += employeesList_MouseDoubleClick;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "First Name";
			columnHeader2.Width = 90;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Last Name";
			columnHeader3.Width = 90;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Date of birth";
			columnHeader4.Width = 90;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Salary";
			columnHeader5.Width = 90;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Phone";
			columnHeader6.Width = 90;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "Email";
			// 
			// SelectEmployeeDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(612, 411);
			Controls.Add(employeesList);
			Name = "SelectEmployeeDialog";
			Text = "Select a employee (double click to select)";
			ResumeLayout(false);
		}

		#endregion

		private ListView employeesList;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader11;
	}
}