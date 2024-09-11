namespace PersonalHotel
{
	internal class Employee : ITable
	{
		public Employee(Database db, int id, string firstName, string lastName, DateTime birth, uint salary, string phone, string email) : base(db)
		{
			if (firstName.Length > 50) throw new ArgumentException("First name must be shorter than 50 characters");
			if (lastName.Length > 50) throw new ArgumentException("Last name must be shorter than 50 characters");
			if (phone.Length > 50) throw new ArgumentException("Phone number must be shorter than 50 characters");
			if (email.Length > 100) throw new ArgumentException("Email address must be shorter than 100 characters");

			ID = id;
			FirstName = firstName;
			LastName = lastName;
			BirthDate = birth;
			Salary = salary;
			Phone = phone;
			Email = email;
		}

		public Employee(Database db, string firstName, string lastName, DateTime birth, uint salary, string phone, string email) : base(db)
		{
			if (firstName.Length > 50) throw new ArgumentException("First name must be shorter than 50 characters");
			if (lastName.Length > 50) throw new ArgumentException("Last name must be shorter than 50 characters");
			if (phone.Length > 50) throw new ArgumentException("Phone number must be shorter than 50 characters");
			if (email.Length > 100) throw new ArgumentException("Email address must be shorter than 100 characters");

			FirstName = firstName;
			LastName = lastName;
			BirthDate = birth;
			Salary = salary;
			Phone = phone;
			Email = email;

			using (var r = _db.Execute("INSERT INTO employees(first_name, last_name, birth_date, salary, phone, email)" +
				" VALUES(@pFirstName, @pLastName, @pBirth, @pSalary, @pPhone, @pEmail);" +
				"SELECT LAST_INSERT_ID();",
				new KeyValuePair("@pFirstName", firstName),
				new KeyValuePair("@pLastName", lastName),
				new KeyValuePair("@pBirth", birth),
				new KeyValuePair("@pSalary", salary),
				new KeyValuePair("@pPhone", phone),
				new KeyValuePair("@pEmail", email)
				))
			{
				if (r == null) throw new Exception("Failed to create employee in database");
				r.Read();

				ID = r.GetInt32(0);

				r.Close();
			}
		}

		public Employee(Database db, int id) : base(db)
		{
			ID = id;

			using (var r = db.Execute("SELECT * FROM employees WHERE id = @pID", new KeyValuePair("@pID", id)))
			{
				if (r == null) throw new Exception("Employee retrieval failed.");
				r.Read();

				FirstName = r.GetString(1);
				LastName = r.GetString(2);
				BirthDate = r.GetDateTime(3);
				Salary = r.GetUInt32(4);
				Phone = r.GetString(5);
				Email = r.GetString(6);

				r.Close();
			}
		}

		public int ID { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public DateTime BirthDate { get; private set; }
		public uint Salary { get; private set; }
		public string Phone { get; private set; }
		public string Email { get; private set; }

		public override void Update()
		{
			_db.ExecuteNQ("UPDATE employees SET " +
				" first_name = @pFirstName," +
				" last_name = @pLastName," +
				" birth_date = @pBirth," +
				" salary = @pSalary," +
				" phone = @pPhone," +
				" email = @pEmail" +
				" WHERE id = @pID",
				new KeyValuePair("@pFirstName", FirstName),
				new KeyValuePair("@pLastName", LastName),
				new KeyValuePair("@pBirth", BirthDate),
				new KeyValuePair("@pSalary", Salary),
				new KeyValuePair("@pPhone", Phone),
				new KeyValuePair("@pEmail", Email),
				new KeyValuePair("@pID", ID)
			);
		}

		public override void Remove()
		{
			_db.ExecuteNQ("DELETE FROM employees WHERE id = @pID", new KeyValuePair("@pID", ID));

			ID = -1;
			FirstName = LastName = Phone = Email = "";
			BirthDate = DateTime.MinValue;
			Salary = 0;
		}

		public override string ToString()
		{
			return ID + " " + FirstName + " " + LastName; 
		}
	}
}
