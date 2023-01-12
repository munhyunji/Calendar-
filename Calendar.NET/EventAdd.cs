using System;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
using CalendarDemo = Calendar.NETDemo;

namespace Calendar.NET
{
    internal partial class EventAdd : Form
    {

        private IEvent _event;
        private IEvent _newEvent;

        XmlDocument xmlDoc;
        String XmlFileName = "Data.xml";



        public EventAdd()
        {
            InitializeComponent();

            Date.TextChanged += Date_TextChanged;
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Date.Texts) && !string.IsNullOrEmpty(DateText.Texts))
            {
                int day = Int32.Parse(Date.Texts);
                String dayText = Date.Texts.Trim() + "일차 " + DateText.Texts.Trim();

                xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFileName);

                if (File.Exists(XmlFileName))
                {

                    try
                    {
                     
                    }catch (Exception ex) {
                        MessageBox.Show(ex.ToString());
                    }

                    var Add_custom = new CustomEvent
                    {

                    };

                }

                this.Close();
            } else
            {
                MessageBox.Show("시험일차와 내용을 작성해주세요.");
            }
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
                Date.Texts = "";
                return;
            }
        }

 
    }
}
