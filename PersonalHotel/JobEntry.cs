namespace PersonalHotel
{
	internal class JobEntry : ITable
	{
		public JobEntry(Database db, int ID, Employee employee, Job job, DateTime start, DateTime? end) : base(db)
		{
			if (employee == null) throw new ArgumentNullException("employee");
			if (job == null) throw new ArgumentNullException("job");

			this.ID = ID;
			Employee = employee;
			Job = job;
			Start = start;
			End = end;
		}

		public JobEntry(Database db, Employee employee, Job job, DateTime start, DateTime? end) : base(db)
		{
			if (employee == null) throw new ArgumentNullException("employee");
			if (job == null) throw new ArgumentNullException("job");

			Employee = employee;
			Job = job;
			Start = start;
			End = end;

			using (var r = db.Execute("INSERT INTO job_history(employee_id, job_id, start_date, end_date) " +
				"VALUES(@pEmployeeID, @pJobID, @pStart, @pEnd);" +
				"SELECT LAST_INSERT_ID();",
				new KeyValuePair("@pEmployeeID", Employee.ID),
				new KeyValuePair("@pJobID", Job.ID),
				new KeyValuePair("@pStart", start),
				new KeyValuePair("@pEnd", end.HasValue ? end.Value : null)
				))
			{
				if (r == null) throw new Exception("Failed to save job entry into the database");
				r.Read();

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
				r.Read();

				Employee = new Employee(db, r.GetInt32(1));
				Job = new Job(db, r.GetInt32(2));
				Start = r.GetDateTime(3);

				End = !r.IsDBNull(4) ? r.GetDateTime(4) : null;

				r.Close();
			}
		}

		public JobEntry(Database db, int id, bool marked_for_removal) : base(db)
		{
		}

		public int ID { get; private set; }
		public Employee Employee { get;private set; }
		public Job Job { get; private set; }
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
				new KeyValuePair("@pEmployeeID", Employee.ID),
				new KeyValuePair("@pJobID", Job.ID),
				new KeyValuePair("@pStart", Start),
				new KeyValuePair("@pEnd", End),
				new KeyValuePair("@pID", ID)
			);
		}

		public override void Remove()
		{
			_db.ExecuteNQ("DELETE FROM job_history WHERE entry_id = @ID", new KeyValuePair("@ID", ID));

			ID = -1;
			Employee = null;
			Job = null;
			Start = DateTime.MinValue;
			End = null;
		}
	}
}
