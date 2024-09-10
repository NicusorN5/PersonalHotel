namespace PersonalHotel
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		Database _db;

		private void MainMenu_Load(object sender, EventArgs e)
		{
			_db = new DatabaseSingleton().Get();

			MainMenu_Resize(sender, e);
		}

		private void MainMenu_Resize(object sender, EventArgs e)
		{
			tabControl.Location = new Point(5, menuStrip1.Size.Height);
			tabControl.Size = new Size(Size.Width - 25, Size.Height - menuStrip1.Size.Height - 40);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void newJobTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (JobDialog dialog = new(_db))
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{

				}
			}
		}

		private void changeEmployeeTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
