namespace PersonalHotel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Database _db;

		private void Form1_Load(object sender, EventArgs e)
		{
			_db = new DatabaseSingleton().Get();
		}
	}
}
