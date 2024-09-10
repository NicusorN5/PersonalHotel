using MySqlX.XDevAPI.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalHotel
{
	internal partial class JobDialog : Form
	{
		public JobDialog(Database db)
		{
			InitializeComponent();

			_db = db;
		}

		Database _db;

		public JobDialog(Database db, Job j) : this(db)
		{
			this.Text = "Edit job";

			this.textBox1.Text = j.Title;
			this.numericUpDown1.Value = j.MinSalary;
			this.numericUpDown2.Value = j.MaxSalary;
		}

		Job? _result;
		public Job? ReturnedJob
		{
			get => _result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_result = new Job(
				_db,
				textBox1.Text,
				(uint)numericUpDown1.Value,
				(uint)numericUpDown2.Value
			);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
