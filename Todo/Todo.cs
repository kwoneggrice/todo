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
using Todo.Dialogs;

namespace Todo
{
	public partial class Todo : Form
	{
		public Todo()
		{
			InitializeComponent();
		}

		// 폼 로드 시 동작
		private void Todo_Load(object sender, EventArgs e)
		{
			todoDgv.DataSource = TodoQuery.Instance.SelectAllQuery();
		}

		// 저장 버튼 클릭 이벤트
		private void saveBtn_Click(object sender, EventArgs e)
		{
			string content = contentTb.Text;
			DateTime startDate = startDateDtp.Value;
			DateTime endDate = endDateDtp.Value;

			DialogResult dr = MessageBox.Show("입력한 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);

			// 메시지박스 값에 따라 저장 로직 
			if (dr == DialogResult.Yes)
			{
				TodoQuery.Instance.SaveQuery(content, startDate, endDate);
				contentTb.Text = "";
				startDateDtp.Value = DateTime.Now;
				endDateDtp.Value = DateTime.Now;
				todoDgv.DataSource = TodoQuery.Instance.SelectAllQuery();

			}
			else
			{
				MessageBox.Show("저장을 취소하셨습니다..", "저장 취소", MessageBoxButtons.OK);
			}


		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			UpdateDialog updateDialog = new UpdateDialog();
			updateDialog.Show();
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

			if (dr == DialogResult.Yes)
			{
				DataGridViewRow row = todoDgv.SelectedRows[0];
				int id = int.Parse(row.Cells[0].Value.ToString());

				TodoQuery.Instance.DeleteQuery(id);
				todoDgv.DataSource = TodoQuery.Instance.SelectAllQuery();
			}
			else
			{
				MessageBox.Show("삭제를 취소하셨습니다.", "삭제 취소", MessageBoxButtons.OK);
			}
		}
	}
}
