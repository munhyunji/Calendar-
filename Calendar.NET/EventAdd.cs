using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace Calendar.NET
{
    internal partial class EventAdd : Form
    {

        private IEvent _event;
        private IEvent _newEvent;

        XmlDocument xmlDoc;
        String XmlFileName = "Date.xml";



        public EventAdd()
        {
            InitializeComponent();
        }

        public IEvent Event
        {
            get { return Event; }
            set
            {
                _event = value;
                FillValue();
            }
        }

        public IEvent NewEvent
        {
            get { return NewEvent; }
            
        }

        private void FillValue()
        {
            TestName.Text = _event.EventText.ToString();
            TestDate.Text = _event.Date.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 확인버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 취소버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            Regex num = new Regex(@"[0-9]"); //숫자만
            Boolean isMatch = num.IsMatch(Date.Texts);

            if(!isMatch)
            {
                MessageBox.Show("숫자만 입력해주세요.");
                Date.Texts = "";
            }
        }
    }
}
