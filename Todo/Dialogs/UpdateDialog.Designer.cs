namespace Todo.Dialogs
{
	partial class UpdateDialog
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
			label1 = new Label();
			label2 = new Label();
			updateStartDateDtp = new DateTimePicker();
			updateEndDateDtp = new DateTimePicker();
			label3 = new Label();
			updateContentTb = new TextBox();
			updateBtn = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 12F);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 0;
			label1.Text = "시작일";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 12F);
			label2.Location = new Point(238, 9);
			label2.Name = "label2";
			label2.Size = new Size(58, 21);
			label2.TabIndex = 1;
			label2.Text = "마감일";
			// 
			// updateStartDateDtp
			// 
			updateStartDateDtp.Location = new Point(12, 33);
			updateStartDateDtp.Name = "updateStartDateDtp";
			updateStartDateDtp.Size = new Size(200, 23);
			updateStartDateDtp.TabIndex = 2;
			// 
			// updateEndDateDtp
			// 
			updateEndDateDtp.Location = new Point(238, 33);
			updateEndDateDtp.Name = "updateEndDateDtp";
			updateEndDateDtp.Size = new Size(200, 23);
			updateEndDateDtp.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 12F);
			label3.Location = new Point(12, 76);
			label3.Name = "label3";
			label3.Size = new Size(42, 21);
			label3.TabIndex = 4;
			label3.Text = "내용";
			// 
			// updateContentTb
			// 
			updateContentTb.Location = new Point(12, 100);
			updateContentTb.Multiline = true;
			updateContentTb.Name = "updateContentTb";
			updateContentTb.Size = new Size(426, 130);
			updateContentTb.TabIndex = 5;
			// 
			// updateBtn
			// 
			updateBtn.Location = new Point(363, 257);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new Size(75, 23);
			updateBtn.TabIndex = 6;
			updateBtn.Text = "업데이트";
			updateBtn.UseVisualStyleBackColor = true;
			updateBtn.Click += updateBtn_Click;
			// 
			// UpdateDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(450, 292);
			Controls.Add(updateBtn);
			Controls.Add(updateContentTb);
			Controls.Add(label3);
			Controls.Add(updateEndDateDtp);
			Controls.Add(updateStartDateDtp);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "UpdateDialog";
			Text = "UpdateDialog";
			Load += UpdateDialog_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private DateTimePicker updateStartDateDtp;
		private DateTimePicker updateEndDateDtp;
		private Label label3;
		private TextBox updateContentTb;
		private Button updateBtn;
	}
}