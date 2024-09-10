using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
