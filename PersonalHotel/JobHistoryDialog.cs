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
					_employee = new Employee(_db, d.SelectedEmployeeID);
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
					_job = new Job(_db, d.SelectedJobID);
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
			_entry = new JobEntry(_db, _employee.ID, _job.ID, monthCalendar1.SelectionStart, checkBox1.Enabled ? monthCalendar2.SelectionStart : null);
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
