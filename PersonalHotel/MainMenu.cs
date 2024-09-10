using Mysqlx.Datatypes;

using System.Diagnostics;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
				if(d.ShowDialog() == DialogResult.OK)
				{
					Job j = d.Job ?? throw new ArgumentNullException();
					_jobs.Add(j);
					jobList.Items.Add(new ListViewItem(new string[] { j.ID + "", j.Title, j.MinSalary + "", j.MaxSalary+"" });
				}
			}
		}

		private void changeEmployeeTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var d = new JobHistoryDialog(_db))
			{
				if(d.ShowDialog() == DialogResult.OK)
				{
					JobEntry j = d.JobHistoryEntry ?? throw new ArgumentNullException();
					_jobsEntry.Add(j);
					jobHistoryList.Items.Add(new ListViewItem(new string[] { j.ID + "", FindEmployeeByID(j.EmployeeID) + "", FindJobByID(j.JobID) + "", j.Start + "", j.End.HasValue ? j.End + "" : "N/A" }));
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
				while (r.HasRows)
				{
					int id = r.GetInt32(0);
					string FirstName = r.GetString(1);
					string LastName = r.GetString(2);
					DateTime BirthDate = r.GetDateTime(3);
					uint Salary = r.GetUInt32(4);
					string Phone = r.GetString(5);
					string Email = r.GetString(6);

					_employees.Add(new Employee(_db, id, FirstName, LastName, BirthDate, Salary, Phone, Email));
					employeesList.Items.Add(new ListViewItem(new string[] { id + "", FirstName, LastName, BirthDate + "", Salary + "", Phone, Email, FindEmployeeCurrentTitle(id) }));

					r.NextResult();
				}
			}
		}
		private void btnRefreshJobList_Click(object sender, EventArgs e)
		{
			_jobs.Clear();
			jobList.Items.Clear();

			using (var r = _db.Execute("SELECT * FROM jobs"))
			{
				int id = r.GetInt32(0);
				string title = r.GetString(1);
				uint minSalary = r.GetUInt32(2);
				uint maxSalary = r.GetUInt32(3);

				_jobs.Add(new Job(_db, id, title, minSalary, maxSalary));
				jobList.Items.Add(new ListViewItem(new string[] { id + "", title, minSalary + "", maxSalary + "" }));

				r.NextResult();
			}
		}

		private void btnRefreshJobHistoryList_Click(object sender, EventArgs e)
		{
			_jobsEntry.Clear();
			jobHistoryList.Items.Clear(); 

			using (var r = _db.Execute("SELECT * FROM job_history"))
			{
				int id = r.GetInt32(0);
				int employeeID = r.GetInt32(1);
				int jobID = r.GetInt32(2);
				DateTime start = r.GetDateTime(3);
				DateTime? end = !r.IsDBNull(4) ? r.GetDateTime(4) : null;

				_jobsEntry.Add(new JobEntry(_db, id, employeeID, jobID, start, end));
				jobHistoryList.Items.Add(new ListViewItem(new string[] { id+"", FindEmployeeByID(employeeID)+"", FindJobByID(jobID)+"", start+"", end.HasValue ? end+"" : "None" }));
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnRefreshEmployees_Click(sender, e);
			btnRefreshJobList_Click(sender, e);
		}
		#endregion

		private void deleteEmployeeBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in employeesList.SelectedItems)
			{
				Debugger.Break();
			}
		}

		#region Edit row

		private void editEmployeeBtn_Click(object sender, EventArgs e)
		{

		}

		private void btnEditJob_Click(object sender, EventArgs e)
		{

		}

		private void btnEditJobEntry_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region helpers
		Employee? FindEmployeeByID(int id)
		{
			foreach(Employee e in _employees)
			{
				if (e.ID == id) return e;
			}

			return null;
		}

		Job? FindJobByID(int id)
		{ 
			foreach(Job j in _jobs)
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
				result = r.GetString(0);
			}

			return result;
		}
		#endregion
	}
}
