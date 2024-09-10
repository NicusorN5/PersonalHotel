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

		internal SelectEmployeeDialog(Database db)
		{
			InitializeComponent();

			employeesList.Items.Clear();

			using (var r = db.Execute("SELECT * FROM employees"))
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

					_employees.Add(new Employee(db, id, FirstName, LastName, BirthDate, Salary, Phone, Email));

					employeesList.Items.Add(new ListViewItem(new string[] { id + "", FirstName, LastName, BirthDate + "", Salary + "", Phone, Email }));
				}
			}
		}

		public int SelectedEmployeeID;

		private void employeesList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Debugger.Log(0,null,employeesList.SelectedItems[0] + "");
			Debugger.Break();
		}
	}
}
