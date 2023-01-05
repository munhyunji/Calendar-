﻿using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Calendar.NETDemo;

namespace Calendar.NET
{
    internal partial class EventDetails : Form
    {
        private IEvent _event;
        private IEvent _newEvent;

        XmlDocument xmlDoc;
        String XmlFileName = "Data.xml";
        

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }

        public EventDetails()
        {
            InitializeComponent();
           // PopulateComboBox();
        }

        private void EventDetailsLoad(object sender, EventArgs e)
        {

        }

       /* private void PopulateComboBox()
        {
            cbRecurringFrequency.Items.Add("None");
            cbRecurringFrequency.Items.Add("Custom");
            cbRecurringFrequency.Items.Add("Daily");
            cbRecurringFrequency.Items.Add("Every Monday, Wednesday and Friday");
            cbRecurringFrequency.Items.Add("Every Tuesday and Thursday");
            cbRecurringFrequency.Items.Add("Every Week Day (Mon - Fri)");
            cbRecurringFrequency.Items.Add("Every Weekend (Sat & Sun)");
            cbRecurringFrequency.Items.Add("Every Month");
            cbRecurringFrequency.Items.Add("Every week");
            cbRecurringFrequency.Items.Add("Every year");
        }*/

        private RecurringFrequencies StringToRecurringFrequencies(string f)
        {
            RecurringFrequencies retval = RecurringFrequencies.None;

            if (f.Equals("Custom"))
                retval = RecurringFrequencies.Custom;
            if (f.Equals("Daily"))
                retval = RecurringFrequencies.Daily;
            if (f.Equals("Every Monday, Wednesday and Friday"))
                retval = RecurringFrequencies.EveryMonWedFri;
            if (f.Equals("Every Tuesday and Thursday"))
                retval = RecurringFrequencies.EveryTueThurs;
            if (f.Equals("Every Week Day (Mon - Fri)"))
                retval = RecurringFrequencies.EveryWeekday;
            if (f.Equals("Every Weekend (Sat & Sun)"))
                retval = RecurringFrequencies.EveryWeekend;
            if (f.Equals("Every Month"))
                retval = RecurringFrequencies.Monthly;
            if (f.Equals("Every week"))
                retval = RecurringFrequencies.Weekly;
            if (f.Equals("Every year"))
                retval = RecurringFrequencies.Yearly;
            if (f.Equals("None"))
                retval = RecurringFrequencies.None;
            return retval;
        }

        private string RecurringFrequencyToString(RecurringFrequencies f)
        {
            string retval = "";

            switch (f)
            {
                case RecurringFrequencies.Custom:
                    retval = "Custom";
                    break;
                case RecurringFrequencies.Daily:
                    retval = "Daily";
                    break;
                case RecurringFrequencies.EveryMonWedFri:
                    retval = "Every Monday, Wednesday and Friday";
                    break;
                case RecurringFrequencies.EveryTueThurs:
                    retval = "Every Tuesday and Thursday";
                    break;
                case RecurringFrequencies.EveryWeekday:
                    retval = "Every Week Day (Mon - Fri)";
                    break;
                case RecurringFrequencies.EveryWeekend:
                    retval = "Every Weekend (Sat & Sun)";
                    break;
                case RecurringFrequencies.Monthly:
                    retval = "Every Month";
                    break;
                case RecurringFrequencies.None:
                    retval = "None";
                    break;
                case RecurringFrequencies.Weekly:
                    retval = "Every week";
                    break;
                case RecurringFrequencies.Yearly:
                    retval = "Every year";
                    break;
            }
            return retval;
        }

        /// <summary>
        /// 이벤트 데이터 불러오기 
        /// </summary>
        private void FillValues()
        {
            String ev = _event.EventText.ToString();
            EventTitle.Text = _event.EventText;

            if (ev.Contains("\n"))
            {
                txtEventName1.Texts = ev.Substring(0, ev.IndexOf("\n"));
                txtEventName2.Texts = ev.Substring(ev.LastIndexOf("\n")).Trim();
                txtEventName1.Enabled = false;
                txtTestAmt.Enabled = false;
                
            } else
            {
                txtEventName1.Texts = ev;
                txtEventName2.Enabled = false;
            }


            
            monthCalendar1.SelectionRange = new SelectionRange(_event.Date, _event.Date);

            //검체량 값 불러오기...,
            xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFileName);

            if (File.Exists(XmlFileName))
            {
                XmlNodeList TestNodes = xmlDoc.SelectNodes("Root/Test");

                for (int i = 0; i < TestNodes.Count; i++)
                {
                    if (ev.Contains(TestNodes[i].Attributes["Name"].Value.Trim().ToString()))
                    {
                        txtTestAmt.Texts = TestNodes[i].Attributes["GumAmt"].Value;
                        
                    }
                }
            }


            //txtTestAmt.Texts = 
            //dtDate.Value = _event.Date;
            //dtDate.CustomFormat = _event.IgnoreTimeComponent ? "M/d/yyyy" : "M/d/yyyy h:mm tt";
            // cbRecurringFrequency.SelectedItem = RecurringFrequencyToString(_event.RecurringFrequency);
            // chkThisDayForwardOnly.Enabled = _event.RecurringFrequency != RecurringFrequencies.None;
            //chkEnabled.Checked = _event.Enabled;
            lblFont.Text = _event.EventFont.FontFamily.Name + " " + _event.EventFont.Size.ToString(CultureInfo.InvariantCulture) + "pt";
            pnlEventColor.BackColor = _event.EventColor;
            pnlTextColor.BackColor = _event.EventTextColor;

           // chkEnableTooltip.Checked = _event.TooltipEnabled;

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";
            
            _newEvent = _event.Clone();
        }

        private void BtnFontClick(object sender, EventArgs e)
        {
            fontDialog1.Font = _newEvent.EventFont;
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _newEvent.EventFont = fontDialog1.Font;
            }
        }


        /// <summary>
        /// 이벤트 디테일 저장완료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOkClick(object sender, EventArgs e)
        {
            
            _newEvent.Date = monthCalendar1.SelectionStart;
            _newEvent.EventColor = pnlEventColor.BackColor;
            
            DialogResult = DialogResult.OK;

           
            //xml파일 로드 
            xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFileName);

            if (File.Exists(XmlFileName))
            {
                try
                {
                    if (!String.IsNullOrEmpty(_newEvent.EventText))
                    {
                        if (_event.Rank == 1)
                        {
                            XmlNodeList GumChe = xmlDoc.SelectNodes("Root/GumChe");

                            for(int i = 0; i < GumChe.Count; i++)
                            {
                                if(_event.EventText == GumChe[i].Attributes["Name"].Value && _event.Date.ToString("yyyy-MM-dd") == GumChe[i].Attributes["Datetime"].Value)
                                {
                                    GumChe[i].Attributes["Name"].Value = txtEventName1.Texts;
                                    
                                    xmlDoc.Save(XmlFileName);

                                    _newEvent.EventText = txtEventName1.Texts;

                                }
                            }
                        } else if ( _event.Rank == 2)
                        {
                            XmlNodeList Test = xmlDoc.SelectNodes("Root/Test");

                            for (int i = 0; i < Test.Count; i++)
                            {
                                if(_event.EventText.Contains(Test[i].Attributes["Name"].Value.Replace("\n", "")))
                                {
                                     Test[i].Attributes["Name"].Value = txtEventName1.Texts;
                                     Test[i].Attributes["Color"].Value = _newEvent.EventColor.ToString();

                                    if(txtEventName2.Enabled == false)
                                    {
                                        _newEvent.EventText = txtEventName1.Texts;
                                    } else
                                    {
                                        if (Test[i].Attributes.GetNamedItem("NameDate") != null)
                                        {
                                            if (_event.EventText.Contains(Test[i].Attributes["Name"].Value.Replace("\n", "")) && _event.EventText.Contains(Test[i].Attributes["NameDate"].Value.ToString()))
                                            {
                                                Test[i].Attributes["NameDate"].Value = txtEventName2.Texts;
                                                Test[i].Attributes["Datetime"].Value = _newEvent.Date.ToString("yyyy-MM-dd");
                                            }
                                        }
                                        _newEvent.EventText = txtEventName1.Texts + "\n" + TextAlignCenter_DaysName(txtEventName1.Texts, txtEventName2.Texts);
                                    }
                                       
                                } 


                            }
                        } 

                        xmlDoc.Save(XmlFileName);
                    }
                    else
                    {
                        MessageBox.Show("일정제목을 입력해주세요");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            } else
            {
                MessageBox.Show("설정 저장에 실패했습니다.");
            }

            Close();
        }

        /// <summary>
        /// 이벤트 색상 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlEventColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _newEvent.EventColor;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlEventColor.BackColor = colorDialog1.Color;
                _newEvent.EventColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// 이벤트 텍스트 색상
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlTextColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _newEvent.EventColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlTextColor.BackColor = colorDialog1.Color;
                _newEvent.EventTextColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// 시험 일차 가운데 정렬 
        /// </summary>
        /// <param name="TestName"></param>
        /// <param name="DaysName"></param>
        /// <returns></returns>
        private String TextAlignCenter_DaysName(String TestName, String DaysName)
        {

            DaysName = DaysName.PadLeft(TestName.Length + 2);

            return DaysName;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
