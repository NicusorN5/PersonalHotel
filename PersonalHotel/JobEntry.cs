using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHotel
{
	internal class JobEntry : ITable
	{
		public JobEntry(Database db, int ID, int employeeID, int jobID, DateTime start, DateTime? end) : base(db)
		{
			this.ID = ID;
			EmployeeID = employeeID;
			JobID = jobID;
			Start = start;
			End = end;
		}

		public JobEntry(Database db, int ID, Employee employee, Job job, DateTime start, DateTime? end) : this(db, ID ,employee.ID, job.ID, start, end)
		{
			//Calls 1st ctor
			if (employee == null) throw new ArgumentNullException("employee");
			if (job == null) throw new ArgumentNullException("job");
		}

		public JobEntry(Database db, Employee employee, Job job, DateTime start, DateTime? end) : this(db, employee.ID, job.ID, start, end)
		{
			//Calls 4th ctor
			if (employee == null) throw new ArgumentNullException("employee");
			if (job == null) throw new ArgumentNullException("job");
		}

		public JobEntry(Database db, int employeeID, int jobID, DateTime start, DateTime? end) : base(db)
		{
			EmployeeID = employeeID;
			JobID = jobID;
			Start = start;
			End = end;

			using (var r = db.Execute("INSERT INTO job_history(employee_id, job_id, start_date, end_date) " +
				"VALUES(@pEmployeeID, @pJobID, @pStart, @pEnd);" +
				"SELECT LAST_INSERT_ID();",
				new KeyValuePair("@pEmployeeID", EmployeeID),
				new KeyValuePair("@pJobID", JobID),
				new KeyValuePair("@pStart", start),
				new KeyValuePair("@pEnd", end.HasValue ? end.Value : null)
				))
			{
				if (r == null) throw new Exception("Failed to save job entry into the database");

				ID = r.GetInt32(0);

				r.Close();
			}
		}

		public JobEntry(Database db, int id) : base(db)
		{
			ID = id;

			using(var r = db.Execute("SELECT * FROM job_history WHERE entry_id = @id", new KeyValuePair("@id",id)))
			{
				if (r == null) throw new Exception("Failed to read job entry from database");

				EmployeeID = r.GetInt32(1);
				JobID = r.GetInt32(2);
				Start = r.GetDateTime(3);

				End = !r.IsDBNull(4) ? r.GetDateTime(4) : null;

				r.Close();
			}
		}

		public int ID { get; private set; }
		public int EmployeeID { get;private set; }
		public int JobID { get; private set; }
		public DateTime Start { get; private set; }
		public DateTime? End { get; private set; }

		public override void Update()
		{
			_db.ExecuteNQ("UPDATE job_history SET " +
				"employee_id = @pEmployeeID," +
				"job_id = @pJobID," +
				"start_date = @pStart," +
				"end_date = @pEnd" +
				" WHERE entry_id = @pID",
				new KeyValuePair("@pEmployeeID", EmployeeID),
				new KeyValuePair("@pJobID", JobID),
				new KeyValuePair("@pStart", Start),
				new KeyValuePair("@pEnd", End),
				new KeyValuePair("@pID", ID)
			);
		}

		public override void Remove()
		{
			_db.ExecuteNQ("DELETE FROM job_history WHERE entry_id = @ID", new KeyValuePair("@ID", ID));

			ID = EmployeeID = JobID = -1;
			Start = DateTime.MinValue;
			End = null;
		}
	}
}
