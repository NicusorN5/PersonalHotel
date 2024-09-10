using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHotel
{
	internal class Employee
	{
		public Employee(Database db, string firstName, string lastName, DateTime birth, uint salary, string phone, string email)
		{

		}

		public Employee(Database db, int id)
		{
			var r = db.Execute("SELECT * FROM employees WHERE id = @pID", new KeyValuePair("@pID", id));
			if (r == null) throw new Exception("Employee retrieval failed.");

			FirstName = r.GetString(1);
			LastName = r.GetString(2);
			Birth = r.GetDateTime(3);
			Salary = r.GetUInt32(4);
			Phone = r.GetString(5);
			Email = r.GetString(6);

			r.Close();
		}

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public DateTime Birth { get; private set; }
		public uint Salary { get; private set; }
		public string Phone { get; private set; }
		public string Email { get; private set; }


	}
}
