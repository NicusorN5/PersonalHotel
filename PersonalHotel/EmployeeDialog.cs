namespace PersonalHotel
{
	internal partial class EmployeeDialog : Form
	{
		Database _db;

		public EmployeeDialog(Database db)
		{
			if (db == null) throw new ArgumentNullException("db");
			_db = db;

			InitializeComponent();
		}

		public EmployeeDialog(Database db, Employee e) : this(db)
		{
			Text = "Edit employee";

			tbFirstName.Text = e.FirstName;
			tbLastName.Text = e.LastName;
			monthCalendar1.SetDate(e.BirthDate);
			numericUpDown1.Value = (decimal)e.Salary;
			tbPhone.Text = e.Phone;
			tbEmail.Text = e.Email;

			_result = e;
		}

		Employee? _result = null;
		public Employee? Employee
		{
			get => _result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_result == null)
			{
				_result = new Employee(
					_db,
					tbFirstName.Text,
					tbLastName.Text,
					monthCalendar1.SelectionStart,
					(uint)numericUpDown1.Value,
					tbPhone.Text,
					tbEmail.Text
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
