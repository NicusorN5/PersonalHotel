using System.Diagnostics;

using static System.Reflection.Metadata.BlobBuilder;

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

		private void jobList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Debugger.Log(0, null, jobList.SelectedItems[0] + "");
			Debugger.Break();
		}

		private void SelectJobDialog_Load(object sender, EventArgs e)
		{
			_jobs.Clear();
			jobList.Items.Clear();

			using (var r = _db.Execute("SELECT * FROM jobs"))
			{
				int id = r.GetInt32(0);
				string title = r.GetString(1);
				uint minSalary = r.GetUInt32(2);
				uint maxSalary = r.GetUInt32(3);

				_jobs.Add(new Job(_db, id, title, minSalary, maxSalary));
				jobList.Items.Add(new ListViewItem(new string[] { id + "", title, minSalary + "", maxSalary + "" }));

				r.NextResult();
			}
		}

		public int SelectedJobID;
	}
}
