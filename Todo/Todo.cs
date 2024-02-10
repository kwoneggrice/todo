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
			}
			else
			{
				MessageBox.Show("저장에 실패하셨습니다.", "저장 실패", MessageBoxButtons.OK);
			}


		}
	}
}
