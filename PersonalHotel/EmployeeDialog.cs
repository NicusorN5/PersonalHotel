using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalHotel
{
	internal partial class EmployeeDialog : Form
	{
		Database _db;

		public EmployeeDialog(Database db)
		{
			InitializeComponent();
			_db = db;
		}

		public EmployeeDialog(Database db, Employee e) : this(db)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
