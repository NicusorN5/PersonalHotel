using Microsoft.Data.Sqlite;

namespace PersonalHotel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using (var connection = new SqliteConnection("Data Source=hotel.db"))
			{
				connection.Open();

				var command = connection.CreateCommand();
				command.CommandText = @"CREATE TABLE IF NOT EXISTS users(name STRING, int ID)";

				command.ExecuteNonQuery();
			}
		}
	}
}
