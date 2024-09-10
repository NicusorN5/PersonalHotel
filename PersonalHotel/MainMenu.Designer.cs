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
			btnRefreshEmployees = new Button();
			deleteEmployeeBtn = new Button();
			editEmployeeBtn = new Button();
			newEmployeeBtn = new Button();
			employeesList = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			columnHeader12 = new ColumnHeader();
			jobTitlesPage = new TabPage();
			btnDeleteJob = new Button();
			btnRefreshJobList = new Button();
			btnEditJob = new Button();
			btnAddNewJob = new Button();
			jobList = new ListView();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			jobHistoryPage = new TabPage();
			btnDeleteJobEntry = new Button();
			btnRefreshJobHistoryList = new Button();
			btnEditJobEntry = new Button();
			btnAddNewJobEntry = new Button();
			jobHistoryList = new ListView();
			columnHeader13 = new ColumnHeader();
			columnHeader14 = new ColumnHeader();
			columnHeader15 = new ColumnHeader();
			columnHeader16 = new ColumnHeader();
			columnHeader17 = new ColumnHeader();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			refreshAllToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			addToolStripMenuItem = new ToolStripMenuItem();
			newEmployeeToolStripMenuItem = new ToolStripMenuItem();
			newJobTitleToolStripMenuItem = new ToolStripMenuItem();
			changeEmployeeTitleToolStripMenuItem = new ToolStripMenuItem();
			tabControl.SuspendLayout();
			EmployeesPage.SuspendLayout();
			jobTitlesPage.SuspendLayout();
			jobHistoryPage.SuspendLayout();
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
			tabControl.Size = new Size(948, 426);
			tabControl.TabIndex = 0;
			// 
			// EmployeesPage
			// 
			EmployeesPage.Controls.Add(btnRefreshEmployees);
			EmployeesPage.Controls.Add(deleteEmployeeBtn);
			EmployeesPage.Controls.Add(editEmployeeBtn);
			EmployeesPage.Controls.Add(newEmployeeBtn);
			EmployeesPage.Controls.Add(employeesList);
			EmployeesPage.Location = new Point(4, 24);
			EmployeesPage.Name = "EmployeesPage";
			EmployeesPage.Padding = new Padding(3);
			EmployeesPage.Size = new Size(940, 398);
			EmployeesPage.TabIndex = 0;
			EmployeesPage.Text = "Employees";
			EmployeesPage.UseVisualStyleBackColor = true;
			// 
			// btnRefreshEmployees
			// 
			btnRefreshEmployees.Location = new Point(788, 64);
			btnRefreshEmployees.Name = "btnRefreshEmployees";
			btnRefreshEmployees.Size = new Size(146, 23);
			btnRefreshEmployees.TabIndex = 4;
			btnRefreshEmployees.Text = "Refresh list";
			btnRefreshEmployees.UseVisualStyleBackColor = true;
			btnRefreshEmployees.Click += btnRefreshEmployees_Click;
			// 
			// deleteEmployeeBtn
			// 
			deleteEmployeeBtn.Location = new Point(788, 351);
			deleteEmployeeBtn.Name = "deleteEmployeeBtn";
			deleteEmployeeBtn.Size = new Size(148, 41);
			deleteEmployeeBtn.TabIndex = 3;
			deleteEmployeeBtn.Text = "Delete selected employee";
			deleteEmployeeBtn.UseVisualStyleBackColor = true;
			deleteEmployeeBtn.Click += deleteEmployeeBtn_Click;
			// 
			// editEmployeeBtn
			// 
			editEmployeeBtn.Location = new Point(786, 35);
			editEmployeeBtn.Name = "editEmployeeBtn";
			editEmployeeBtn.Size = new Size(148, 23);
			editEmployeeBtn.TabIndex = 2;
			editEmployeeBtn.Text = "Edit selected employee";
			editEmployeeBtn.UseVisualStyleBackColor = true;
			editEmployeeBtn.Click += editEmployeeBtn_Click;
			// 
			// newEmployeeBtn
			// 
			newEmployeeBtn.Location = new Point(786, 6);
			newEmployeeBtn.Name = "newEmployeeBtn";
			newEmployeeBtn.Size = new Size(148, 23);
			newEmployeeBtn.TabIndex = 1;
			newEmployeeBtn.Text = "Add new employee";
			newEmployeeBtn.UseVisualStyleBackColor = true;
			newEmployeeBtn.Click += newEmployeeToolStripMenuItem_Click;
			// 
			// employeesList
			// 
			employeesList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader11, columnHeader12 });
			employeesList.Location = new Point(6, 6);
			employeesList.Name = "employeesList";
			employeesList.Size = new Size(774, 386);
			employeesList.TabIndex = 0;
			employeesList.UseCompatibleStateImageBehavior = false;
			employeesList.View = View.Details;
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
			// columnHeader12
			// 
			columnHeader12.Text = "Current title";
			columnHeader12.Width = 90;
			// 
			// jobTitlesPage
			// 
			jobTitlesPage.Controls.Add(btnDeleteJob);
			jobTitlesPage.Controls.Add(btnRefreshJobList);
			jobTitlesPage.Controls.Add(btnEditJob);
			jobTitlesPage.Controls.Add(btnAddNewJob);
			jobTitlesPage.Controls.Add(jobList);
			jobTitlesPage.Location = new Point(4, 24);
			jobTitlesPage.Name = "jobTitlesPage";
			jobTitlesPage.Padding = new Padding(3);
			jobTitlesPage.Size = new Size(940, 398);
			jobTitlesPage.TabIndex = 1;
			jobTitlesPage.Text = "Job titles";
			jobTitlesPage.UseVisualStyleBackColor = true;
			// 
			// btnDeleteJob
			// 
			btnDeleteJob.Location = new Point(787, 364);
			btnDeleteJob.Name = "btnDeleteJob";
			btnDeleteJob.Size = new Size(147, 23);
			btnDeleteJob.TabIndex = 4;
			btnDeleteJob.Text = "Delete selected job";
			btnDeleteJob.UseVisualStyleBackColor = true;
			// 
			// btnRefreshJobList
			// 
			btnRefreshJobList.Location = new Point(787, 64);
			btnRefreshJobList.Name = "btnRefreshJobList";
			btnRefreshJobList.Size = new Size(147, 23);
			btnRefreshJobList.TabIndex = 3;
			btnRefreshJobList.Text = "Refresh list";
			btnRefreshJobList.UseVisualStyleBackColor = true;
			btnRefreshJobList.Click += btnRefreshJobList_Click;
			// 
			// btnEditJob
			// 
			btnEditJob.Location = new Point(787, 35);
			btnEditJob.Name = "btnEditJob";
			btnEditJob.Size = new Size(147, 23);
			btnEditJob.TabIndex = 2;
			btnEditJob.Text = "Edit selected job";
			btnEditJob.UseVisualStyleBackColor = true;
			btnEditJob.Click += btnEditJob_Click;
			// 
			// btnAddNewJob
			// 
			btnAddNewJob.Location = new Point(787, 6);
			btnAddNewJob.Name = "btnAddNewJob";
			btnAddNewJob.Size = new Size(147, 23);
			btnAddNewJob.TabIndex = 1;
			btnAddNewJob.Text = "Add new job";
			btnAddNewJob.UseVisualStyleBackColor = true;
			btnAddNewJob.Click += newJobTitleToolStripMenuItem_Click;
			// 
			// jobList
			// 
			jobList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
			jobList.Location = new Point(6, 6);
			jobList.Name = "jobList";
			jobList.Size = new Size(775, 381);
			jobList.TabIndex = 0;
			jobList.UseCompatibleStateImageBehavior = false;
			jobList.View = View.Details;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "ID";
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Title";
			columnHeader8.Width = 90;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "Minimum salary";
			columnHeader9.Width = 120;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Maximum salary";
			columnHeader10.Width = 120;
			// 
			// jobHistoryPage
			// 
			jobHistoryPage.Controls.Add(btnDeleteJobEntry);
			jobHistoryPage.Controls.Add(btnRefreshJobHistoryList);
			jobHistoryPage.Controls.Add(btnEditJobEntry);
			jobHistoryPage.Controls.Add(btnAddNewJobEntry);
			jobHistoryPage.Controls.Add(jobHistoryList);
			jobHistoryPage.Location = new Point(4, 24);
			jobHistoryPage.Name = "jobHistoryPage";
			jobHistoryPage.Size = new Size(940, 398);
			jobHistoryPage.TabIndex = 2;
			jobHistoryPage.Text = "Job history";
			jobHistoryPage.UseVisualStyleBackColor = true;
			// 
			// btnDeleteJobEntry
			// 
			btnDeleteJobEntry.Location = new Point(764, 364);
			btnDeleteJobEntry.Name = "btnDeleteJobEntry";
			btnDeleteJobEntry.Size = new Size(173, 23);
			btnDeleteJobEntry.TabIndex = 4;
			btnDeleteJobEntry.Text = "Delete selected job entry";
			btnDeleteJobEntry.UseVisualStyleBackColor = true;
			// 
			// btnRefreshJobHistoryList
			// 
			btnRefreshJobHistoryList.Location = new Point(764, 61);
			btnRefreshJobHistoryList.Name = "btnRefreshJobHistoryList";
			btnRefreshJobHistoryList.Size = new Size(173, 23);
			btnRefreshJobHistoryList.TabIndex = 3;
			btnRefreshJobHistoryList.Text = "Refresh list";
			btnRefreshJobHistoryList.UseVisualStyleBackColor = true;
			btnRefreshJobHistoryList.Click += btnRefreshJobHistoryList_Click;
			// 
			// btnEditJobEntry
			// 
			btnEditJobEntry.Location = new Point(764, 32);
			btnEditJobEntry.Name = "btnEditJobEntry";
			btnEditJobEntry.Size = new Size(173, 23);
			btnEditJobEntry.TabIndex = 2;
			btnEditJobEntry.Text = "Edit selected job entry";
			btnEditJobEntry.UseVisualStyleBackColor = true;
			btnEditJobEntry.Click += btnEditJobEntry_Click;
			// 
			// btnAddNewJobEntry
			// 
			btnAddNewJobEntry.Location = new Point(764, 3);
			btnAddNewJobEntry.Name = "btnAddNewJobEntry";
			btnAddNewJobEntry.Size = new Size(173, 23);
			btnAddNewJobEntry.TabIndex = 1;
			btnAddNewJobEntry.Text = "Add new job history entry";
			btnAddNewJobEntry.UseVisualStyleBackColor = true;
			btnAddNewJobEntry.Click += changeEmployeeTitleToolStripMenuItem_Click;
			// 
			// jobHistoryList
			// 
			jobHistoryList.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17 });
			jobHistoryList.Location = new Point(3, 3);
			jobHistoryList.Name = "jobHistoryList";
			jobHistoryList.Size = new Size(755, 392);
			jobHistoryList.TabIndex = 0;
			jobHistoryList.UseCompatibleStateImageBehavior = false;
			jobHistoryList.View = View.Details;
			// 
			// columnHeader13
			// 
			columnHeader13.Text = "ID";
			// 
			// columnHeader14
			// 
			columnHeader14.Text = "Employee";
			columnHeader14.Width = 150;
			// 
			// columnHeader15
			// 
			columnHeader15.Text = "Job";
			columnHeader15.Width = 120;
			// 
			// columnHeader16
			// 
			columnHeader16.Text = "Start date";
			columnHeader16.Width = 90;
			// 
			// columnHeader17
			// 
			columnHeader17.Text = "End date";
			columnHeader17.Width = 90;
			// 
			// menuStrip1
			// 
			menuStrip1.GripStyle = ToolStripGripStyle.Visible;
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, addToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(984, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshAllToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// refreshAllToolStripMenuItem
			// 
			refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
			refreshAllToolStripMenuItem.Size = new Size(128, 22);
			refreshAllToolStripMenuItem.Text = "Refresh all";
			refreshAllToolStripMenuItem.Click += refreshAllToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(128, 22);
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
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 450);
			Controls.Add(tabControl);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			MaximumSize = new Size(1000, 489);
			MinimumSize = new Size(1000, 489);
			Name = "MainMenu";
			Text = "Management Hotel";
			Load += MainMenu_Load;
			Resize += MainMenu_Resize;
			tabControl.ResumeLayout(false);
			EmployeesPage.ResumeLayout(false);
			jobTitlesPage.ResumeLayout(false);
			jobHistoryPage.ResumeLayout(false);
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
		private ListView employeesList;
		private Button newEmployeeBtn;
		private Button deleteEmployeeBtn;
		private Button editEmployeeBtn;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private Button btnRefreshEmployees;
		private ListView jobList;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private Button btnAddNewJob;
		private Button btnEditJob;
		private ToolStripMenuItem refreshAllToolStripMenuItem;
		private ColumnHeader columnHeader11;
		private ColumnHeader columnHeader12;
		private Button btnRefreshJobList;
		private Button btnDeleteJob;
		private ListView jobHistoryList;
		private ColumnHeader columnHeader13;
		private ColumnHeader columnHeader14;
		private ColumnHeader columnHeader15;
		private ColumnHeader columnHeader16;
		private ColumnHeader columnHeader17;
		private Button btnAddNewJobEntry;
		private Button btnEditJobEntry;
		private Button btnRefreshJobHistoryList;
		private Button btnDeleteJobEntry;
	}
}
