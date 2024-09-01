using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHotel
{
	public struct KeyValuePair
	{
		public string Name;
		public object Value;
	}

	internal class Database
	{
		static SqliteConnection _conn;

		public Database()
		{
			_conn = new SqliteConnection("Data Source=hotel.db");
			if (_conn == null) throw new Exception("Database initialization failed!");
			
			_conn.Open();
		}

		public SqliteDataReader Execute(string query, params KeyValuePair[] objects)
		{
			SqliteCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			foreach(KeyValuePair pair in objects)
			{
				cmd.Parameters.AddWithValue(pair.Name, pair.Value);
			}

			return cmd.ExecuteReader();
		}


		public void Execute(string query)
		{
			SqliteCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			cmd.ExecuteNonQuery();
		}
	}
}
