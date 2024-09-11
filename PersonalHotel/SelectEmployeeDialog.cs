using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalHotel
{
	internal partial class SelectEmployeeDialog : Form
	{
		List<Employee> _employees = new();
		Database _db;

		internal SelectEmployeeDialog(Database db)
		{
			InitializeComponent();
			_db = db;

			employeesList.Items.Clear();

			using (var r = db.Execute("SELECT * FROM employees"))
			{
				while (r.Read())
				{
					int id = r.GetInt32(0);
					string FirstName = r.GetString(1);
					string LastName = r.GetString(2);
					DateTime BirthDate = r.GetDateTime(3);
					uint Salary = r.GetUInt32(4);
					string Phone = r.GetString(5);
					string Email = r.GetString(6);

					_employees.Add(new Employee(db, id, FirstName, LastName, BirthDate, Salary, Phone, Email));

					employeesList.Items.Add(new ListViewItem(new string[] { id + "", FirstName, LastName, BirthDate + "", Salary + "", Phone, Email }));
				}

				r.Close();
			}
		}

		public Employee SelectedEmployee;

		private void employeesList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var item = employeesList.SelectedItems[0];

			int id = Convert.ToInt32(item.Text);

			string first_name = item.SubItems[1].Text;
			string last_name = item.SubItems[2].Text;
			DateTime dob = Convert.ToDateTime(item.SubItems[3].Text);
			uint salary = Convert.ToUInt32(item.SubItems[4].Text);
			string phone = item.SubItems[5].Text;
			string email = item.SubItems[6].Text;

			SelectedEmployee = new Employee(_db, id, first_name, last_name, dob, salary, phone, email);
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
