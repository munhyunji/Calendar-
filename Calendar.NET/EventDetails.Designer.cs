﻿namespace Calendar.NET
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.EventTitle = new System.Windows.Forms.Label();
            this.txtTestAmt = new CustomControls.RJControls.RJTextBox();
            this.txtEventName = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIgnoreTimeComponent = new System.Windows.Forms.CheckBox();
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
            this.label9 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "일정 날짜";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label9);
            this.gbBasics.Controls.Add(this.EventTitle);
            this.gbBasics.Controls.Add(this.txtTestAmt);
            this.gbBasics.Controls.Add(this.txtEventName);
            this.gbBasics.Controls.Add(this.panel1);
            this.gbBasics.Controls.Add(this.label7);
            this.gbBasics.Controls.Add(this.label3);
            this.gbBasics.Controls.Add(this.chkIgnoreTimeComponent);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBasics.Location = new System.Drawing.Point(18, 13);
            this.gbBasics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBasics.Size = new System.Drawing.Size(309, 413);
            this.gbBasics.TabIndex = 4;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "일정 설정";
            // 
            // EventTitle
            // 
            this.EventTitle.AutoSize = true;
            this.EventTitle.Location = new System.Drawing.Point(134, 30);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(92, 17);
            this.EventTitle.TabIndex = 9;
            this.EventTitle.Text = "이벤트타이틀";
            this.EventTitle.Visible = false;
            // 
            // txtTestAmt
            // 
            this.txtTestAmt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTestAmt.BorderColor = System.Drawing.Color.Lavender;
            this.txtTestAmt.BorderFocusColor = System.Drawing.Color.Thistle;
            this.txtTestAmt.BorderSize = 2;
            this.txtTestAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestAmt.ForeColor = System.Drawing.Color.DimGray;
            this.txtTestAmt.Location = new System.Drawing.Point(17, 359);
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
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEventName.BorderColor = System.Drawing.Color.Lavender;
            this.txtEventName.BorderFocusColor = System.Drawing.Color.Thistle;
            this.txtEventName.BorderSize = 2;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.ForeColor = System.Drawing.Color.DimGray;
            this.txtEventName.Location = new System.Drawing.Point(17, 297);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Multiline = false;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Padding = new System.Windows.Forms.Padding(7);
            this.txtEventName.PasswordChar = false;
            this.txtEventName.Size = new System.Drawing.Size(265, 35);
            this.txtEventName.TabIndex = 9;
            this.txtEventName.Texts = "";
            this.txtEventName.UnderlinedStyle = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(134, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "*공백은 수정하지마세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "검체량";
            // 
            // chkIgnoreTimeComponent
            // 
            this.chkIgnoreTimeComponent.AutoSize = true;
            this.chkIgnoreTimeComponent.Checked = true;
            this.chkIgnoreTimeComponent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreTimeComponent.Location = new System.Drawing.Point(113, 16);
            this.chkIgnoreTimeComponent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIgnoreTimeComponent.Name = "chkIgnoreTimeComponent";
            this.chkIgnoreTimeComponent.Size = new System.Drawing.Size(146, 21);
            this.chkIgnoreTimeComponent.TabIndex = 5;
            this.chkIgnoreTimeComponent.Text = "시간 표시하지않음";
            this.chkIgnoreTimeComponent.UseVisualStyleBackColor = true;
            this.chkIgnoreTimeComponent.Visible = false;
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
            this.groupBox1.Location = new System.Drawing.Point(18, 438);
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
            this.btnOk.Location = new System.Drawing.Point(18, 614);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 26);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(203, 614);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(31, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "개발중";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(346, 665);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetailsLoad);
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.CheckBox chkIgnoreTimeComponent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel pnlEventColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtEventName;
        private CustomControls.RJControls.RJTextBox txtTestAmt;
        private System.Windows.Forms.Label EventTitle;
        private System.Windows.Forms.Label label9;
    }
}