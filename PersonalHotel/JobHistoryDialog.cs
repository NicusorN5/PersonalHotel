namespace PersonalHotel
{
	internal partial class JobHistoryDialog : Form
	{
		Database _db;

		internal JobHistoryDialog(Database db)
		{
			_db = db;
			InitializeComponent();
			checkBox1_CheckedChanged(this, null);
		}

		internal JobHistoryDialog(Database db, JobEntry job) : this(db)
		{
			Text = "Edit job history entry";
			_entry = job;

			_employee = job.Employee;
			textBox1.Text = _employee + "";

			_job = job.Job;
			textBox2.Text = _job + "";

			monthCalendar1.SetDate(job.Start);

			if (job.End.HasValue)
			{
				monthCalendar2.SetDate(job.End.Value);
				monthCalendar2.Enabled = true;
				checkBox1.Checked = true;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			monthCalendar2.Enabled = checkBox1.Checked;
		}

		Employee _employee = null;
		Job _job = null;

		private void button1_Click(object sender, EventArgs e)
		{
			using (SelectEmployeeDialog d = new(_db))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					_employee = d.SelectedEmployee;
					textBox1.Text = _employee.ToString();
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (SelectJobDialog d = new(_db))
			{
				if (d.ShowDialog() == DialogResult.OK)
				{
					_job = d.SelectedJob;
					textBox2.Text = _job.ToString();
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (_entry == null)
			{
				_entry = new JobEntry(
					_db,
					_employee,
					_job,
					monthCalendar1.SelectionStart,
					checkBox1.Checked ? monthCalendar2.SelectionStart : null
				);
			}
			else
			{
				_entry = new JobEntry(
					_db,
					_entry.ID,
					_employee,
					_job,
					monthCalendar1.SelectionStart,
					checkBox1.Checked ? monthCalendar2.SelectionStart : null
				);
				_entry.Update();
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		JobEntry _entry;
		public JobEntry JobHistoryEntry
		{
			get => _entry;
		}
	}
}
