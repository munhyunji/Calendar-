using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar.NETDemo
{
    class RashiDateTimePicker : DateTimePicker
    {
        private Color fillColor = Color.LightSeaGreen;
        private Color textColor = Color.White;
        private Color borderColor = Color.Gray;
        private int borderSize = 0;



        private bool dropDown = true;
        private Image CalenderImg = Properties.Resources.calendarWhite;
        private RectangleF iconButton;
        private const int iconWidth = 34;
        private const int arrowWidth = 17;

        public Color FillColor
        {
            get
            {
                return fillColor;
            }
            set
            {
                fillColor = value;
                //if (fillColor.GetBrightness() >= 0.6f)
               // {
                //    CalenderImg = Properties.Resources.calendarDark;
               // }
               // else
              //  {
                    CalenderImg = Properties.Resources.calendarWhite;
              //  }
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }



        public RashiDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5f);
        }



        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            dropDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            dropDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen pen = new Pen(borderColor, borderSize))
            using (SolidBrush fillBrush = new SolidBrush(fillColor))
            using (SolidBrush textBruh = new SolidBrush(textColor))
            using (SolidBrush iconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (StringFormat format = new StringFormat())
            {
                RectangleF dtpArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(dtpArea.Width - iconWidth, 0, iconWidth, dtpArea.Height);
                pen.Alignment = PenAlignment.Inset;
                format.LineAlignment = StringAlignment.Center;


                graphics.FillRectangle(fillBrush, dtpArea);
                graphics.DrawString("    " + this.Text, this.Font, textBruh, dtpArea, format);

                if (dropDown == true) graphics.FillRectangle(iconBrush, iconArea);
                if (borderSize >= 1) graphics.DrawRectangle(pen, dtpArea.X, dtpArea.Y, dtpArea.Width, dtpArea.Height);

                graphics.DrawImage(CalenderImg, this.Width - CalenderImg.Width - 9, (this.Height - CalenderImg.Height) / 2);

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconWidth();
            iconButton = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButton.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }



        private int GetIconWidth()
        {
            int textwidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textwidth <= this.Width - (iconWidth + 20))
                return iconWidth;
            else return arrowWidth;
        }
    }
}

