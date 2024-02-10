﻿using System;
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

		private void Todo_Load(object sender, EventArgs e)
		{

		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			string content = contentTb.Text;
			DateTime startDate = startDateDtp.Value;
			DateTime endDate = endDateDtp.Value;

			TodoQuery.Instance.SaveQuery(content, startDate, endDate);
		}
	}
}
