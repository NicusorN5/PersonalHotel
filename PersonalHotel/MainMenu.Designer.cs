namespace PersonalHotel
{
	partial class MainMenu
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
			tabControl = new TabControl();
			EmployeesPage = new TabPage();
			deleteEmployeeBtn = new Button();
			editEmployeeBtn = new Button();
			newEmployeeBtn = new Button();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			jobTitlesPage = new TabPage();
			jobHistoryPage = new TabPage();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			addToolStripMenuItem = new ToolStripMenuItem();
			newEmployeeToolStripMenuItem = new ToolStripMenuItem();
			newJobTitleToolStripMenuItem = new ToolStripMenuItem();
			changeEmployeeTitleToolStripMenuItem = new ToolStripMenuItem();
			button1 = new Button();
			tabControl.SuspendLayout();
			EmployeesPage.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(EmployeesPage);
			tabControl.Controls.Add(jobTitlesPage);
			tabControl.Controls.Add(jobHistoryPage);
			tabControl.Location = new Point(24, 27);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(776, 426);
			tabControl.TabIndex = 0;
			// 
			// EmployeesPage
			// 
			EmployeesPage.Controls.Add(button1);
			EmployeesPage.Controls.Add(deleteEmployeeBtn);
			EmployeesPage.Controls.Add(editEmployeeBtn);
			EmployeesPage.Controls.Add(newEmployeeBtn);
			EmployeesPage.Controls.Add(listView1);
			EmployeesPage.Location = new Point(4, 24);
			EmployeesPage.Name = "EmployeesPage";
			EmployeesPage.Padding = new Padding(3);
			EmployeesPage.Size = new Size(768, 398);
			EmployeesPage.TabIndex = 0;
			EmployeesPage.Text = "Employees";
			EmployeesPage.UseVisualStyleBackColor = true;
			// 
			// deleteEmployeeBtn
			// 
			deleteEmployeeBtn.Location = new Point(614, 351);
			deleteEmployeeBtn.Name = "deleteEmployeeBtn";
			deleteEmployeeBtn.Size = new Size(148, 41);
			deleteEmployeeBtn.TabIndex = 3;
			deleteEmployeeBtn.Text = "Delete selected employee";
			deleteEmployeeBtn.UseVisualStyleBackColor = true;
			// 
			// editEmployeeBtn
			// 
			editEmployeeBtn.Location = new Point(612, 35);
			editEmployeeBtn.Name = "editEmployeeBtn";
			editEmployeeBtn.Size = new Size(148, 23);
			editEmployeeBtn.TabIndex = 2;
			editEmployeeBtn.Text = "Edit selected employee";
			editEmployeeBtn.UseVisualStyleBackColor = true;
			// 
			// newEmployeeBtn
			// 
			newEmployeeBtn.Location = new Point(612, 6);
			newEmployeeBtn.Name = "newEmployeeBtn";
			newEmployeeBtn.Size = new Size(148, 23);
			newEmployeeBtn.TabIndex = 1;
			newEmployeeBtn.Text = "Add new employee";
			newEmployeeBtn.UseVisualStyleBackColor = true;
			newEmployeeBtn.Click += newEmployeeToolStripMenuItem_Click;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
			listView1.Location = new Point(6, 6);
			listView1.Name = "listView1";
			listView1.Size = new Size(600, 386);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
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
			columnHeader5.Text = "Current Title";
			columnHeader5.Width = 90;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Hire date";
			columnHeader6.Width = 90;
			// 
			// jobTitlesPage
			// 
			jobTitlesPage.Location = new Point(4, 24);
			jobTitlesPage.Name = "jobTitlesPage";
			jobTitlesPage.Padding = new Padding(3);
			jobTitlesPage.Size = new Size(768, 398);
			jobTitlesPage.TabIndex = 1;
			jobTitlesPage.Text = "Job titles";
			jobTitlesPage.UseVisualStyleBackColor = true;
			// 
			// jobHistoryPage
			// 
			jobHistoryPage.Location = new Point(4, 24);
			jobHistoryPage.Name = "jobHistoryPage";
			jobHistoryPage.Size = new Size(768, 398);
			jobHistoryPage.TabIndex = 2;
			jobHistoryPage.Text = "Job history";
			jobHistoryPage.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			menuStrip1.GripStyle = ToolStripGripStyle.Visible;
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, addToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(93, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// addToolStripMenuItem
			// 
			addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newEmployeeToolStripMenuItem, newJobTitleToolStripMenuItem, changeEmployeeTitleToolStripMenuItem });
			addToolStripMenuItem.Name = "addToolStripMenuItem";
			addToolStripMenuItem.Size = new Size(41, 20);
			addToolStripMenuItem.Text = "Add";
			// 
			// newEmployeeToolStripMenuItem
			// 
			newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
			newEmployeeToolStripMenuItem.Size = new Size(193, 22);
			newEmployeeToolStripMenuItem.Text = "New employee";
			newEmployeeToolStripMenuItem.Click += newEmployeeToolStripMenuItem_Click;
			// 
			// newJobTitleToolStripMenuItem
			// 
			newJobTitleToolStripMenuItem.Name = "newJobTitleToolStripMenuItem";
			newJobTitleToolStripMenuItem.Size = new Size(193, 22);
			newJobTitleToolStripMenuItem.Text = "New job title";
			newJobTitleToolStripMenuItem.Click += newJobTitleToolStripMenuItem_Click;
			// 
			// changeEmployeeTitleToolStripMenuItem
			// 
			changeEmployeeTitleToolStripMenuItem.Name = "changeEmployeeTitleToolStripMenuItem";
			changeEmployeeTitleToolStripMenuItem.Size = new Size(193, 22);
			changeEmployeeTitleToolStripMenuItem.Text = "Change employee title";
			changeEmployeeTitleToolStripMenuItem.Click += changeEmployeeTitleToolStripMenuItem_Click;
			// 
			// button1
			// 
			button1.Location = new Point(614, 64);
			button1.Name = "button1";
			button1.Size = new Size(146, 23);
			button1.TabIndex = 4;
			button1.Text = "Refresh list";
			button1.UseVisualStyleBackColor = true;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			MaximumSize = new Size(816, 489);
			MinimumSize = new Size(816, 489);
			Name = "MainMenu";
			Text = "Management Hotel";
			Load += MainMenu_Load;
			Resize += MainMenu_Resize;
			tabControl.ResumeLayout(false);
			EmployeesPage.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl;
		private TabPage EmployeesPage;
		private TabPage jobTitlesPage;
		private TabPage jobHistoryPage;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem newEmployeeToolStripMenuItem;
		private ToolStripMenuItem newJobTitleToolStripMenuItem;
		private ToolStripMenuItem changeEmployeeTitleToolStripMenuItem;
		private ListView listView1;
		private Button newEmployeeBtn;
		private Button deleteEmployeeBtn;
		private Button editEmployeeBtn;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private Button button1;
	}
}
