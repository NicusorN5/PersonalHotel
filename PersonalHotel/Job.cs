using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHotel
{
	class Job
	{
		public int Id { get; private set; }
		public string Title { get; private set; }
		public uint MinSalary { get; private set; }
		public uint MaxSalary { get; private set; }

		public Job(Database db, string title, uint minSalary, uint maxSalary)
		{
			if (db == null) throw new ArgumentNullException("db");
			if (title.Length > 50) throw new ArgumentException("Title cannot be longer than 50 characters, since this is a table limitation");

			Title = title;
			MinSalary = minSalary;
			MaxSalary = maxSalary;
			Id = -1;

			using (var r = db.Execute("INSERT INTO jobs(title, min_salary, max_salary) VALUES(@pName, @pMinSalary, @pMaxSalary);" +
				"SELECT LAST_INSERT_ID();",
				new KeyValuePair("@pName", Title),
				new KeyValuePair("@pMinSalary", minSalary),
				new KeyValuePair("@pMaxSalary", maxSalary)
			))
			{
				if (r == null) throw new Exception("Job creation query failed.");

				Id = r.GetInt32(0);

				r.Close();
			}
		}


		public Job(Database db, int id)
		{
			if (db == null) throw new ArgumentNullException("db");

			using (var r = db.Execute("SELECT * FROM jobs WHERE job_id = @id", new KeyValuePair("@id", id)))
			{
				if (r == null) throw new Exception("Job retrieval query failed");

				Title = r.GetString(1);
				MinSalary = r.GetUInt32(2);
				MaxSalary = r.GetUInt32(3);

				r.Close();
			}
		}

		void Update(Database db)
		{
			if (db == null) throw new ArgumentNullException("db");

			db.ExecuteNQ("UPDATE jobs SET title = @pTitle, min_salary = @pMinSalary, max_salary = @pMaxSalary WHERE job_id = @id",
				new KeyValuePair("@pTitle", Title),
				new KeyValuePair("@pMinSalary", MinSalary),
				new KeyValuePair("@pMaxSalary", MaxSalary),
				new KeyValuePair("@id", Id)
			);
		}

		void Remove(Database db)
		{
			if (db == null) throw new ArgumentNullException("db");

			db.ExecuteNQ("DELETE FROM jobs WHERE job_id = @id", new KeyValuePair("@id", Id));

			Id = -1;
			Title = "";
			MinSalary = MaxSalary = 0;
		}

	}
}
