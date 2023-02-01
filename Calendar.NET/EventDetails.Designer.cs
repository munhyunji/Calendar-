namespace Calendar.NET
{
    partial class EventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName2 = new CustomControls.RJControls.RJTextBox();
            this.txtTestAmt = new CustomControls.RJControls.RJTextBox();
            this.txtEventName1 = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEventColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBasics.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "일정 이름";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Controls.Add(this.txtEventName2);
            this.gbBasics.Controls.Add(this.txtTestAmt);
            this.gbBasics.Controls.Add(this.txtEventName1);
            this.gbBasics.Controls.Add(this.panel1);
            this.gbBasics.Controls.Add(this.label3);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBasics.Location = new System.Drawing.Point(18, 25);
            this.gbBasics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBasics.Size = new System.Drawing.Size(309, 454);
            this.gbBasics.TabIndex = 4;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "일정 설정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(93, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "\"【시험자】\" 는 수정/삭제하지마세요";
            // 
            // txtEventName2
            // 
            this.txtEventName2.BackColor = System.Drawing.SystemColors.Window;
            this.txtEventName2.BorderColor = System.Drawing.Color.Lavender;
            this.txtEventName2.BorderFocusColor = System.Drawing.Color.Thistle;
            this.txtEventName2.BorderSize = 2;
            this.txtEventName2.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName2.ForeColor = System.Drawing.Color.DimGray;
            this.txtEventName2.Location = new System.Drawing.Point(17, 338);
            this.txtEventName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName2.Multiline = false;
            this.txtEventName2.Name = "txtEventName2";
            this.txtEventName2.Padding = new System.Windows.Forms.Padding(7);
            this.txtEventName2.PasswordChar = false;
            this.txtEventName2.Size = new System.Drawing.Size(265, 35);
            this.txtEventName2.TabIndex = 14;
            this.txtEventName2.Texts = "";
            this.txtEventName2.UnderlinedStyle = false;
            // 
            // txtTestAmt
            // 
            this.txtTestAmt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTestAmt.BorderColor = System.Drawing.Color.Lavender;
            this.txtTestAmt.BorderFocusColor = System.Drawing.Color.Thistle;
            this.txtTestAmt.BorderSize = 2;
            this.txtTestAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestAmt.ForeColor = System.Drawing.Color.DimGray;
            this.txtTestAmt.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtTestAmt.Location = new System.Drawing.Point(17, 405);
            this.txtTestAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestAmt.Multiline = false;
            this.txtTestAmt.Name = "txtTestAmt";
            this.txtTestAmt.Padding = new System.Windows.Forms.Padding(7);
            this.txtTestAmt.PasswordChar = false;
            this.txtTestAmt.Size = new System.Drawing.Size(265, 35);
            this.txtTestAmt.TabIndex = 13;
            this.txtTestAmt.Texts = "";
            this.txtTestAmt.UnderlinedStyle = false;
            // 
            // txtEventName1
            // 
            this.txtEventName1.BackColor = System.Drawing.SystemColors.Window;
            this.txtEventName1.BorderColor = System.Drawing.Color.Lavender;
            this.txtEventName1.BorderFocusColor = System.Drawing.Color.Thistle;
            this.txtEventName1.BorderSize = 2;
            this.txtEventName1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName1.ForeColor = System.Drawing.Color.DimGray;
            this.txtEventName1.Location = new System.Drawing.Point(17, 297);
            this.txtEventName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName1.Multiline = false;
            this.txtEventName1.Name = "txtEventName1";
            this.txtEventName1.Padding = new System.Windows.Forms.Padding(7);
            this.txtEventName1.PasswordChar = false;
            this.txtEventName1.Size = new System.Drawing.Size(265, 35);
            this.txtEventName1.TabIndex = 9;
            this.txtEventName1.Texts = "";
            this.txtEventName1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(34, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 198);
            this.panel1.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(-8, -2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "검체량";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pnlTextColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pnlEventColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.lblFont);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(18, 504);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(309, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일정 상태 설정";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "추후개발";
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextColor.Enabled = false;
            this.pnlTextColor.Location = new System.Drawing.Point(244, 76);
            this.pnlTextColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(40, 17);
            this.pnlTextColor.TabIndex = 6;
            this.pnlTextColor.DoubleClick += new System.EventHandler(this.PnlTextColorDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "일정 글씨 색상 설정:";
            // 
            // pnlEventColor
            // 
            this.pnlEventColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventColor.Location = new System.Drawing.Point(244, 37);
            this.pnlEventColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEventColor.Name = "pnlEventColor";
            this.pnlEventColor.Size = new System.Drawing.Size(40, 17);
            this.pnlEventColor.TabIndex = 4;
            this.pnlEventColor.DoubleClick += new System.EventHandler(this.PnlEventColorDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "일정 색상 설정:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "폰트:";
            // 
            // btnFont
            // 
            this.btnFont.Enabled = false;
            this.btnFont.Location = new System.Drawing.Point(244, 115);
            this.btnFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(42, 22);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFontClick);
            // 
            // lblFont
            // 
            this.lblFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFont.Enabled = false;
            this.lblFont.Location = new System.Drawing.Point(61, 116);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(169, 22);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "폰트설정";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOk.Location = new System.Drawing.Point(123, 689);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(200, 26);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(18, 689);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(346, 741);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetailsLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventDetails_KeyDown);
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel pnlEventColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtEventName1;
        private CustomControls.RJControls.RJTextBox txtTestAmt;
        private CustomControls.RJControls.RJTextBox txtEventName2;
        private System.Windows.Forms.Label label2;
    }
}