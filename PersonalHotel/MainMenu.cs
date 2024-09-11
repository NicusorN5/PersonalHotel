namespace PersonalHotel
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		Database _db;

		List<Employee> _employees = new();
		List<Job> _jobs = new();
		List<JobEntry> _jobsEntry = new();

		private void MainMenu_Load(object sender, EventArgs e)
		{
			_db = new DatabaseSingleton().Get();

			MainMenu_Resize(sender, e);

			btnRefreshEmployees_Click(this, null);
			btnRefreshJobList_Click(this, null);
			btnRefreshJobHistoryList_Click(this, null);
		}

		private void MainMenu_Resize(object sender, EventArgs e)
		{
			tabControl.Location = new Point(5, menuStrip1.Size.Height);
			tabControl.Size = new Size(Size.Width - 25, Size.Height - menuStrip1.Size.Height - 40);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#region Add new rows
		private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs eargs)
		{
			using (var d = new EmployeeDialog(_db))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					Employee e = d.Employee ?? throw new ArgumentNullException(); // <-- this is not supposed to happen
					_employees.Add(e);
					employeesList.Items.Add(new ListViewItem(new string[] { e.ID + "", e.FirstName, e.LastName, e.BirthDate + "", e.Salary + "", e.Phone, e.Email }));
				}
			}
		}

		private void newJobTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var d = new JobDialog(_db))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					Job j = d.Job ?? throw new ArgumentNullException();
					_jobs.Add(j);
					jobList.Items.Add(new ListViewItem(new string[] { j.ID + "", j.Title, j.MinSalary + "", j.MaxSalary + "" }));
				}
			}
		}

		private void changeEmployeeTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var d = new JobHistoryDialog(_db))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					JobEntry j = d.JobHistoryEntry ?? throw new ArgumentNullException();
					_jobsEntry.Add(j);
					jobHistoryList.Items.Add(new ListViewItem(new string[] { j.ID + "", j.Employee + "", j.Job + "", j.Start + "", j.End.HasValue ? j.End + "" : "N/A" }));
				}
			}
		}
		#endregion

		#region Refresh buttons

		private void btnRefreshEmployees_Click(object sender, EventArgs e)
		{
			employeesList.Items.Clear();
			_employees.Clear();

			using (var r = _db.Execute("SELECT * FROM employees"))
			{
				if (r == null) throw new NullReferenceException("r");

				while (r.Read())
				{
					int id = r.GetInt32(0);
					string FirstName = r.GetString(1);
					string LastName = r.GetString(2);
					DateTime BirthDate = r.GetDateTime(3);
					uint Salary = r.GetUInt32(4);
					string Phone = r.GetString(5);
					string Email = r.GetString(6);

					_employees.Add(new Employee(_db, id, FirstName, LastName, BirthDate, Salary, Phone, Email));
					employeesList.Items.Add(new ListViewItem(new string[] { id + "", FirstName, LastName, BirthDate + "", Salary + "", Phone, Email, "" }));
				}
				r.Close();
			}
		}
		private void btnRefreshJobList_Click(object sender, EventArgs e)
		{
			_jobs.Clear();
			jobList.Items.Clear();

			using (var r = _db.Execute("SELECT * FROM jobs"))
			{
				if (r == null) throw new NullReferenceException("r");

				while (r.Read())
				{
					int id = r.GetInt32(0);
					string title = r.GetString(1);
					uint minSalary = r.GetUInt32(2);
					uint maxSalary = r.GetUInt32(3);

					_jobs.Add(new Job(_db, id, title, minSalary, maxSalary));
					jobList.Items.Add(new ListViewItem(new string[] { id + "", title, minSalary + "", maxSalary + "" }));
				}
				r.Close();
			}
		}

		private void btnRefreshJobHistoryList_Click(object sender, EventArgs e)
		{
			_jobsEntry.Clear();
			jobHistoryList.Items.Clear();

			using (var r = _db.Execute("SELECT * FROM job_history"))
			{
				if (r == null) throw new NullReferenceException("r");

				while (r.Read())
				{
					int id = r.GetInt32(0);
					Employee employee = FindEmployeeByID(r.GetInt32(1));
					Job job = FindJobByID(r.GetInt32(2));
					DateTime start = r.GetDateTime(3);
					DateTime? end = !r.IsDBNull(4) ? r.GetDateTime(4) : null;

					_jobsEntry.Add(new JobEntry(_db, id, employee, job, start, end));
					jobHistoryList.Items.Add(new ListViewItem(new string[] { id + "", employee + "", job + "", start + "", end.HasValue ? end + "" : "N/A" }));
				}
				r.Close();
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnRefreshEmployees_Click(sender, e);
			btnRefreshJobList_Click(sender, e);
			btnRefreshJobHistoryList_Click(sender, e);
		}
		#endregion

		#region delete row
		private void deleteEmployeeBtn_Click(object sender, EventArgs e)
		{
			ListViewItem item = employeesList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			new Employee(_db, id, "", "", DateTime.MinValue, 0, "", "").Remove();

			_employees.RemoveAll(bool (Employee emp) => { return emp.ID == id; });
			employeesList.Items.Remove(item);
		}

		private void btnDeleteJob_Click(object sender, EventArgs e)
		{
			ListViewItem item = jobList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			new Job(_db, id, "", 0, 0).Remove();

			_jobs.RemoveAll(bool (Job j) => { return j.ID == id; });
			jobList.Items.Remove(item);
		}

		private void btnDeleteJobEntry_Click(object sender, EventArgs e)
		{
			ListViewItem item = jobHistoryList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			new JobEntry(_db, id, true).Remove();
			jobHistoryList.Items.Remove(item);
		}
		#endregion

		#region Edit row

		private void editEmployeeBtn_Click(object sender, EventArgs e)
		{
			var item = employeesList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			string first_name = item.SubItems[1].Text;
			string last_name = item.SubItems[2].Text;
			DateTime dob = Convert.ToDateTime(item.SubItems[3].Text);
			uint salary = Convert.ToUInt32(item.SubItems[4].Text);
			string phone = item.SubItems[5].Text;
			string email = item.SubItems[6].Text;

			using (EmployeeDialog d = new(_db, new Employee(_db, id, first_name, last_name, dob, salary, phone, email)))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					if (d.Employee == null) throw new NullReferenceException();

					item.SubItems[1].Text = d.Employee.FirstName;
					item.SubItems[2].Text = d.Employee.LastName;
					item.SubItems[3].Text = d.Employee.BirthDate + "";
					item.SubItems[4].Text = d.Employee.Salary + "";
					item.SubItems[5].Text = d.Employee.Phone;
					item.SubItems[6].Text = d.Employee.Email;
				}
			}
		}

		private void btnEditJob_Click(object sender, EventArgs e)
		{
			var item = jobList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			string title = item.SubItems[1].Text;
			uint min_salary = Convert.ToUInt32(item.SubItems[2].Text);
			uint max_salary = Convert.ToUInt32(item.SubItems[3].Text);

			using (JobDialog d = new(_db, new Job(_db, id, title, min_salary, max_salary)))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					if (d.Job == null) throw new NullReferenceException();

					item.SubItems[1].Text = d.Job.Title;
					item.SubItems[2].Text = d.Job.MinSalary + "";
					item.SubItems[3].Text = d.Job.MaxSalary + "";
				}
			}
		}

		private void btnEditJobEntry_Click(object sender, EventArgs e)
		{
			var item = jobHistoryList.SelectedItems[0];
			int id = Convert.ToInt32(item.Text);

			JobEntry job = FindJobEntryByID(id);

			using (JobHistoryDialog d = new(_db, job))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					if (d.JobHistoryEntry == null) throw new NullReferenceException();

					item.SubItems[1].Text = d.JobHistoryEntry.Employee + "";
					item.SubItems[2].Text = d.JobHistoryEntry.Job + "";
					item.SubItems[3].Text = d.JobHistoryEntry.Start + "";
					item.SubItems[4].Text = d.JobHistoryEntry.End.HasValue ? job.End.Value + "" : "N/A";
				}
			}
		}
		#endregion

		#region helpers
		Employee? FindEmployeeByID(int id)
		{
			foreach (Employee e in _employees)
			{
				if (e.ID == id) return e;
			}

			return null;
		}

		Job? FindJobByID(int id)
		{
			foreach (Job j in _jobs)
			{
				if (j.ID == id) return j;
			}

			return null;
		}

		JobEntry? FindJobEntryByID(int id)
		{
			foreach(JobEntry j in _jobsEntry)
			{
				if(j.ID == id) return j;
			}
			return null;
		}

		string FindEmployeeCurrentTitle(int employeeID)
		{
			string result;

			using (var r = _db.Execute(
				"SELECT title FROM jobs WHERE job_id = " +
				"(SELECT job_id FROM job_history WHERE employee_id = @EmployeeID ORDER BY start_date DESC LIMIT 1)",
				new KeyValuePair("@EmployeeID", employeeID)))
			{
				if (r == null) return "N/A";
				r.Read();

				result = r.GetString(0);
				r.Close();
			}

			return result;
		}
		#endregion
	}
}
