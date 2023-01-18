
namespace Calendar.NET
{
    partial class EventAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventAdd));
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTestName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateText = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new CustomControls.RJControls.RJTextBox();
            this.TestName = new System.Windows.Forms.Label();
            this.TestDate = new System.Windows.Forms.Label();
            this.txtTestDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_btn.Location = new System.Drawing.Point(258, 250);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(99, 26);
            this.Cancel_btn.TabIndex = 0;
            this.Cancel_btn.Text = "취소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOk.Location = new System.Drawing.Point(23, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 26);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "등록";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.AutoSize = true;
            this.txtTestName.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTestName.Location = new System.Drawing.Point(20, 58);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(83, 20);
            this.txtTestName.TabIndex = 2;
            this.txtTestName.Text = "일정이름 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시험일차 추가";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "*시험일 기준으로 일차 계산되어 자동등록됩니다.";
            // 
            // DateText
            // 
            this.DateText.BackColor = System.Drawing.SystemColors.Window;
            this.DateText.BorderColor = System.Drawing.Color.Lavender;
            this.DateText.BorderFocusColor = System.Drawing.Color.Thistle;
            this.DateText.BorderSize = 2;
            this.DateText.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText.ForeColor = System.Drawing.Color.DimGray;
            this.DateText.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.DateText.Location = new System.Drawing.Point(113, 43);
            this.DateText.Margin = new System.Windows.Forms.Padding(4);
            this.DateText.Multiline = false;
            this.DateText.Name = "DateText";
            this.DateText.Padding = new System.Windows.Forms.Padding(7);
            this.DateText.PasswordChar = false;
            this.DateText.Size = new System.Drawing.Size(198, 35);
            this.DateText.TabIndex = 8;
            this.DateText.Texts = "";
            this.DateText.UnderlinedStyle = false;
            this.DateText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventAdd_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "일차";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.Window;
            this.Date.BorderColor = System.Drawing.Color.Lavender;
            this.Date.BorderFocusColor = System.Drawing.Color.Thistle;
            this.Date.BorderSize = 2;
            this.Date.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.DimGray;
            this.Date.Location = new System.Drawing.Point(22, 44);
            this.Date.Margin = new System.Windows.Forms.Padding(4);
            this.Date.Multiline = false;
            this.Date.Name = "Date";
            this.Date.Padding = new System.Windows.Forms.Padding(7);
            this.Date.PasswordChar = false;
            this.Date.Size = new System.Drawing.Size(44, 35);
            this.Date.TabIndex = 0;
            this.Date.Texts = "";
            this.Date.UnderlinedStyle = false;
            this.Date._TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // TestName
            // 
            this.TestName.AutoSize = true;
            this.TestName.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TestName.Location = new System.Drawing.Point(159, 58);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(55, 20);
            this.TestName.TabIndex = 5;
            this.TestName.Text = "label2";
            // 
            // TestDate
            // 
            this.TestDate.AutoSize = true;
            this.TestDate.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TestDate.Location = new System.Drawing.Point(161, 25);
            this.TestDate.Name = "TestDate";
            this.TestDate.Size = new System.Drawing.Size(55, 20);
            this.TestDate.TabIndex = 7;
            this.TestDate.Text = "label2";
            // 
            // txtTestDate
            // 
            this.txtTestDate.AutoSize = true;
            this.txtTestDate.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTestDate.Location = new System.Drawing.Point(20, 25);
            this.txtTestDate.Name = "txtTestDate";
            this.txtTestDate.Size = new System.Drawing.Size(83, 20);
            this.txtTestDate.TabIndex = 6;
            this.txtTestDate.Text = "일정날짜 :";
            // 
            // EventAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(378, 297);
            this.Controls.Add(this.TestDate);
            this.Controls.Add(this.txtTestDate);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "시험 일차 추가";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventAdd_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label txtTestName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TestName;
        private CustomControls.RJControls.RJTextBox Date;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox DateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TestDate;
        private System.Windows.Forms.Label txtTestDate;
    }
}