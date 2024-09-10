namespace PersonalHotel
{
	class Job : ITable
	{
		public int ID { get; private set; }
		public string Title { get; private set; }
		public uint MinSalary { get; private set; }
		public uint MaxSalary { get; private set; }

		Database _db;

		public Job(Database db, int id, string title,  uint minSalary, uint maxSalary) : base(db)
		{
			if (title.Length > 50) throw new ArgumentException("Title cannot be longer than 50 characters, since this is a table limitation");

			ID = id;
			Title = title;
			MinSalary = minSalary;
			MaxSalary = maxSalary;
		}

		public Job(Database db, string title, uint minSalary, uint maxSalary) : base(db)
		{
			if (title.Length > 50) throw new ArgumentException("Title cannot be longer than 50 characters, since this is a table limitation");

			Title = title;
			MinSalary = minSalary;
			MaxSalary = maxSalary;
			ID = -1;

			using (var r = db.Execute("INSERT INTO jobs(title, min_salary, max_salary) VALUES(@pName, @pMinSalary, @pMaxSalary);" +
				"SELECT LAST_INSERT_ID();",
				new KeyValuePair("@pName", Title),
				new KeyValuePair("@pMinSalary", minSalary),
				new KeyValuePair("@pMaxSalary", maxSalary)
			))
			{
				if (r == null) throw new Exception("Job creation query failed.");

				ID = r.GetInt32(0);

				r.Close();
			}
		}


		public Job(Database db, int id) : base(db)
		{
			ID = id;

			using (var r = db.Execute("SELECT * FROM jobs WHERE job_id = @id", new KeyValuePair("@id", id)))
			{
				if (r == null) throw new Exception("Job retrieval query failed");

				Title = r.GetString(1);
				MinSalary = r.GetUInt32(2);
				MaxSalary = r.GetUInt32(3);

				r.Close();
			}
		}

		public override void Update()
		{
			_db.ExecuteNQ("UPDATE jobs SET title = @pTitle, min_salary = @pMinSalary, max_salary = @pMaxSalary WHERE job_id = @id",
				new KeyValuePair("@pTitle", Title),
				new KeyValuePair("@pMinSalary", MinSalary),
				new KeyValuePair("@pMaxSalary", MaxSalary),
				new KeyValuePair("@id", ID)
			);
		}

		public override void Remove()
		{
			_db.ExecuteNQ("DELETE FROM jobs WHERE job_id = @id", new KeyValuePair("@id", ID));

			ID = -1;
			Title = "";
			MinSalary = MaxSalary = 0;
		}

		public override string ToString()
		{
			return "ID: " + ID + " " + Title + " Salary range ("+MinSalary + " " + MaxSalary + " )";
		}

	}
}
