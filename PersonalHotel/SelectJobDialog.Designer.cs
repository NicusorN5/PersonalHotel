namespace PersonalHotel
{
	partial class SelectJobDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			jobList = new ListView();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			SuspendLayout();
			// 
			// jobList
			// 
			jobList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
			jobList.Dock = DockStyle.Fill;
			jobList.Location = new Point(0, 0);
			jobList.Name = "jobList";
			jobList.Size = new Size(800, 415);
			jobList.TabIndex = 1;
			jobList.UseCompatibleStateImageBehavior = false;
			jobList.View = View.Details;
			jobList.MouseDoubleClick += jobList_MouseDoubleClick;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "ID";
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Title";
			columnHeader8.Width = 90;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "Minimum salary";
			columnHeader9.Width = 120;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Maximum salary";
			columnHeader10.Width = 120;
			// 
			// SelectJobDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 415);
			Controls.Add(jobList);
			Name = "SelectJobDialog";
			Text = "Select a job (double click to select)";
			Load += SelectJobDialog_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView jobList;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
	}
}