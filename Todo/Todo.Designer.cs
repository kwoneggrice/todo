﻿namespace Todo
{
	partial class Todo
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
			todoDgv = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Content = new DataGridViewTextBoxColumn();
			StartDate = new DataGridViewTextBoxColumn();
			EndDate = new DataGridViewTextBoxColumn();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			startDateDtp = new DateTimePicker();
			endDateDtp = new DateTimePicker();
			contentTb = new TextBox();
			saveBtn = new Button();
			updateBtn = new Button();
			deleteBtn = new Button();
			((System.ComponentModel.ISupportInitialize)todoDgv).BeginInit();
			SuspendLayout();
			// 
			// todoDgv
			// 
			todoDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			todoDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			todoDgv.Columns.AddRange(new DataGridViewColumn[] { Id, Content, StartDate, EndDate });
			todoDgv.Location = new Point(12, 12);
			todoDgv.Name = "todoDgv";
			todoDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			todoDgv.Size = new Size(414, 200);
			todoDgv.TabIndex = 0;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.Width = 42;
			// 
			// Content
			// 
			Content.DataPropertyName = "Content";
			Content.HeaderText = "Content";
			Content.Name = "Content";
			Content.Width = 75;
			// 
			// StartDate
			// 
			StartDate.DataPropertyName = "StartDate";
			StartDate.HeaderText = "StartDate";
			StartDate.Name = "StartDate";
			StartDate.Width = 82;
			// 
			// EndDate
			// 
			EndDate.DataPropertyName = "EndDate";
			EndDate.HeaderText = "EndDate";
			EndDate.Name = "EndDate";
			EndDate.Width = 77;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 12F);
			label1.Location = new Point(12, 215);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 1;
			label1.Text = "시작일";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 12F);
			label2.Location = new Point(226, 215);
			label2.Name = "label2";
			label2.Size = new Size(58, 21);
			label2.TabIndex = 2;
			label2.Text = "마감일";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 12F);
			label3.Location = new Point(12, 284);
			label3.Name = "label3";
			label3.Size = new Size(42, 21);
			label3.TabIndex = 3;
			label3.Text = "내용";
			// 
			// startDateDtp
			// 
			startDateDtp.Location = new Point(12, 239);
			startDateDtp.Name = "startDateDtp";
			startDateDtp.Size = new Size(200, 23);
			startDateDtp.TabIndex = 4;
			// 
			// endDateDtp
			// 
			endDateDtp.Location = new Point(226, 239);
			endDateDtp.Name = "endDateDtp";
			endDateDtp.Size = new Size(200, 23);
			endDateDtp.TabIndex = 5;
			// 
			// contentTb
			// 
			contentTb.Location = new Point(12, 308);
			contentTb.Multiline = true;
			contentTb.Name = "contentTb";
			contentTb.Size = new Size(414, 135);
			contentTb.TabIndex = 6;
			// 
			// saveBtn
			// 
			saveBtn.Location = new Point(189, 512);
			saveBtn.Name = "saveBtn";
			saveBtn.Size = new Size(75, 23);
			saveBtn.TabIndex = 7;
			saveBtn.Text = "저장";
			saveBtn.UseVisualStyleBackColor = true;
			saveBtn.Click += saveBtn_Click;
			// 
			// updateBtn
			// 
			updateBtn.Location = new Point(270, 512);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new Size(75, 23);
			updateBtn.TabIndex = 8;
			updateBtn.Text = "수정";
			updateBtn.UseVisualStyleBackColor = true;
			updateBtn.Click += updateBtn_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.Location = new Point(351, 512);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(75, 23);
			deleteBtn.TabIndex = 10;
			deleteBtn.Text = "삭제";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// Todo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(438, 547);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(saveBtn);
			Controls.Add(contentTb);
			Controls.Add(endDateDtp);
			Controls.Add(startDateDtp);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(todoDgv);
			Name = "Todo";
			Text = "Todo";
			Load += Todo_Load;
			((System.ComponentModel.ISupportInitialize)todoDgv).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView todoDgv;
		private Label label1;
		private Label label2;
		private Label label3;
		private DateTimePicker startDateDtp;
		private DateTimePicker endDateDtp;
		private TextBox contentTb;
		private Button saveBtn;
		private Button updateBtn;
		private Button deleteBtn;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Content;
		private DataGridViewTextBoxColumn StartDate;
		private DataGridViewTextBoxColumn EndDate;
	}
}