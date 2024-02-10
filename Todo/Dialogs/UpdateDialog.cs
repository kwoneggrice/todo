using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.DBQuery;
using Todo.Models;

namespace Todo.Dialogs
{
	public partial class UpdateDialog : Form
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public UpdateDialog()
		{
			InitializeComponent();
		}

		private void UpdateDialog_Load(object sender, EventArgs e)
		{
			updateContentTb.Text = Content;
			updateStartDateDtp.Value = StartDate;
			updateEndDateDtp.Value = EndDate;
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("업데이트 하시겠습니까?", "업데이트", MessageBoxButtons.YesNo);

			if (dr == DialogResult.Yes)
			{
				UpdateDialog updateDialog = new UpdateDialog();
				updateDialog.Id = Id;
				updateDialog.Content = updateContentTb.Text;
				updateDialog.StartDate = updateStartDateDtp.Value;
				updateDialog.EndDate = updateEndDateDtp.Value;

				TodoQuery.Instance.UpdateQuery(updateDialog);
				Close();
			}
			else
			{
				Close();
			}
		}
	}
}
