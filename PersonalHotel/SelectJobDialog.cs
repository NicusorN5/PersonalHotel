using System.Diagnostics;

namespace PersonalHotel
{
	internal partial class SelectJobDialog : Form
	{
		Database _db;
		internal SelectJobDialog(Database db)
		{
			_db = db;
			InitializeComponent();
		}

		List<Job> _jobs = new List<Job>();

		private void SelectJobDialog_Load(object sender, EventArgs e)
		{
			_jobs.Clear();
			jobList.Items.Clear();

			using (var r = _db.Execute("SELECT * FROM jobs"))
			{
				while (r.Read())
				{
					int id = r.GetInt32(0);
					string title = r.GetString(1);
					uint minSalary = r.GetUInt32(2);
					uint maxSalary = r.GetUInt32(3);

					_jobs.Add(new Job(_db, id, title, minSalary, maxSalary));
					jobList.Items.Add(new ListViewItem(new string[] { id + "", title, minSalary + "", maxSalary + "" }));
				}
			}
		}

		private void jobList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var item = jobList.SelectedItems[0];

			int id = Convert.ToInt32(item.Text);

			string title = item.SubItems[1].Text;
			uint min_salary = Convert.ToUInt32(item.SubItems[2].Text);
			uint max_salary = Convert.ToUInt32(item.SubItems[3].Text);

			SelectedJob = new Job(_db, id, title, min_salary, max_salary);
			DialogResult = DialogResult.OK;
			Close();
		}

		public Job SelectedJob;
	}
}
