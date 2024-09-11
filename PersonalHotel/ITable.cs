namespace PersonalHotel
{
	internal abstract class ITable
	{
		protected Database _db;

		public ITable(Database db)
		{
			if (db == null) throw new ArgumentNullException("db");
			else _db = db;
		}

		public abstract void Update();
		public abstract void Remove();
	}
}
