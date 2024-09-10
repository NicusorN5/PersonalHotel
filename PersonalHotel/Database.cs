//using Oracle.ManagedDataAccess.Client;
using MySql.Data.MySqlClient;

namespace PersonalHotel
{
	public struct KeyValuePair
	{
		public string Name;
		public object Value;

		public KeyValuePair(string name, object value)
		{
			Name = name;
			Value = value;
		}
	}

	internal class Database : IDisposable
	{
		//OracleConnection _conn;
		MySqlConnection _conn;
		bool _disposed = false;

		public Database()
		{
			/*	
			OracleConnectionStringBuilder connStr = new();
			connStr.UserID = "hotel_admin";
			connStr.Password = "hotel1234";
			connStr.DataSource = "localhost:1521/xe";
			//connStr.ConnectionTimeout = 1500;
			//connStr.MinPoolSize = 0;
			//connStr.MaxPoolSize = 100;

			//"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=MyOracleSID)));User Id=hotel_admin;Password=hotel1234;"

			_conn = new OracleConnection("Data Source=172.20.1.39/Ora09;User Id=hr;Password=oracletest;");
			_conn.Open();
			 */

			MySqlConnectionStringBuilder connStr = new();
			connStr.UserID = "hotel";
			connStr.Password = "hotel1234";
			connStr.Database = "hotel";
			connStr.Server = "localhost";

			_conn = new MySqlConnection(connStr.ConnectionString);
			_conn.Open();
		}

		public MySqlDataReader Execute(string query, params KeyValuePair[] objects)
		{
			//SqliteCommand cmd = _conn.CreateCommand();
			//cmd.CommandText = query;
			MySqlCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			foreach(KeyValuePair pair in objects)
			{
				//cmd.Parameters.AddWithValue(pair.Name, pair.Value);
				cmd.Parameters.AddWithValue(pair.Name, pair.Value);
			}

			//return cmd.ExecuteReader();
			return cmd.ExecuteReader();
		}


		public MySqlDataReader Execute(string query)
		{
			MySqlCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			return cmd.ExecuteReader();

			//SqliteCommand cmd = _conn.CreateCommand();
			//cmd.CommandText = query;

			//cmd.ExecuteNonQuery();
		}

		public int ExecuteNQ(string query, params KeyValuePair[] objects)
		{
			MySqlCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			foreach (KeyValuePair pair in objects)
			{
				//cmd.Parameters.AddWithValue(pair.Name, pair.Value);
				cmd.Parameters.AddWithValue(pair.Name, pair.Value);
			}

			return cmd.ExecuteNonQuery();
		}

		public int ExecuteNQ(string query)
		{
			MySqlCommand cmd = _conn.CreateCommand();
			cmd.CommandText = query;

			return cmd.ExecuteNonQuery();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~Database() 
		{
			_conn.Close();
			Dispose(false); 
		}

		private void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing) _conn.Dispose();
			_disposed = true;
		}
	}
}
