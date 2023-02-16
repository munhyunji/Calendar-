using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Calendar.NETDemo
{
    class RashiRadioButton : RadioButton
    {

        //Fields

        private Color checkColor = Color.LightSeaGreen;
        private Color unCheckColor = Color.Gray;

        public Color CheckColor
        {
            get
            {
               return checkColor;
            }
            set
            {
                checkColor = value;
                this.Invalidate();
            }
        }
        public Color UnCheckColor
        {
            get
            {
                return unCheckColor;
            }
            set
            {
                unCheckColor = value;
                this.Invalidate();
            }
        }




        public RashiRadioButton()
        {
            this.MinimumSize = new Size(0, 20);
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float bordersize = 19f;
            float checkedsize = 13f;

            RectangleF rectangleBorder = new RectangleF()
            {
                X = 0.6f,
                Y = (this.Height - bordersize) / 2,
                Width = bordersize,
                Height = bordersize,
            };

            RectangleF rectangleChecked = new RectangleF()
            {
                X = rectangleBorder.X + ((rectangleBorder.Width - checkedsize) / 2),
                Y = (this.Height - checkedsize) / 2,
                Width = checkedsize,
                Height = checkedsize
            };


            using (Pen PBorder = new Pen(CheckColor, 1.7f))
            using (SolidBrush solidBrush = new SolidBrush(CheckColor))
            using (SolidBrush Btext = new SolidBrush(this.ForeColor))
            {
                graphics.Clear(this.BackColor);
                if (this.Checked)
                {
                    graphics.DrawEllipse(PBorder, rectangleBorder);
                    graphics.FillEllipse(solidBrush, rectangleChecked);
                }
                else
                {
                    PBorder.Color = unCheckColor;
                    graphics.DrawEllipse(PBorder,rectangleBorder);
                }

                graphics.DrawString(this.Text, this.Font, Btext,
                bordersize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);


            }


        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }


    }
}
