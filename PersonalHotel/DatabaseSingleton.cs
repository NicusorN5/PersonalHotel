using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
