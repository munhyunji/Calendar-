using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Calendar.NET
{
    public partial class ScheduleEvent : Form
    {
        private IEvent _event;
        private IEvent _newEvent;

        XmlDocument xmlDoc;
        String XmlFileName = "Data.xml";

        Calendar cal = new Calendar();

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;              
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }


        public ScheduleEvent()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 3;
        }

        /// <summary>
        /// 확인 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime StartDate = StartCalendar.SelectionStart;
                DateTime EndDate = EndCalendar.SelectionStart;

                var ScheduleEvent = new CustomEvent
                {
                    Date = StartDate,
                    EventText = "시험자에요",
                    EventColor = Color.Blue,
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("나눔고딕", 8, FontStyle.Regular),
                    Rank = 1,
                    EventTextColor = Color.Black
                };

                cal.AddEvent(ScheduleEvent);
                Refresh();

                Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

           

        }






        //색상 선택 버튼
        private void colorSelectBtn_Click(object sender, EventArgs e)
        {
            if( colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog1.Color;

            }
        }

        
    }
}
