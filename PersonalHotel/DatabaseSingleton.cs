namespace PersonalHotel
{
	internal class DatabaseSingleton
	{
		static Database _db = null;

		public Database Get()
		{
			if (_db == null)
			{
				_db = new();
			}
			return _db;
		}
 	}
}
