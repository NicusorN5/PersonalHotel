namespace PersonalHotel
{
	internal partial class JobDialog : Form
	{
		public JobDialog(Database db)
		{
			InitializeComponent();

			_db = db;
		}

		Database _db;

		public JobDialog(Database db, Job j) : this(db)
		{
			Text = "Edit job";

			textBox1.Text = j.Title;
			numericUpDown1.Value = j.MinSalary;
			numericUpDown2.Value = j.MaxSalary;

			_result = j;
		}

		Job? _result;
		public Job? ReturnedJob
		{
			get => _result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_result == null)
			{
					_result = new Job(
						_db,
						textBox1.Text,
						(uint)numericUpDown1.Value,
						(uint)numericUpDown2.Value
					);
			}
			else _result.Update();

			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
