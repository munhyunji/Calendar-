﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;



namespace Calendar.NETDemo
{
    public partial class Form1 : Form

    {
        String XmlFileName = "Data.xml";
       

        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]
        private bool RehabDays(IEvent evnt, DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Monday || day.DayOfWeek == DayOfWeek.Friday)
            {
                if (day.Ticks >= (new DateTime(2012, 7, 1)).Ticks)
                    return false;
                return true;
            }

            return false;
        }

        public Form1()
        {
            InitializeComponent();

            calendar1.CalendarDate = DateTime.Today;
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;


            
            dateTimePicker1.Format = DateTimePickerFormat.Long;//날짜 + 시간 형태
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            Form1_Load();



             //var ce = new CustomEvent();

             //ce.EventText = "My Event";
             //ce.Date = new DateTime(2012, 4, 1);
             //ce.RecurringFrequency = RecurringFrequencies.Monthly;
             //ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
             //ce.ThisDayForwardOnly = true;
             //ce.Enabled = true;
             //calendar1.AddEvent(ce);

             //var ce2 = new HolidayEvent();

             //ce2.EventText = "test";
             //ce2.Date = new DateTime(2012, 4, 2);
             //ce2.RecurringFrequency = RecurringFrequencies.EveryMonWedFri;
             //ce2.Rank = 3;
             //calendar1.AddEvent(ce2);

            /* var ce = new CustomEvent();
            ce.IgnoreTimeComponent = false;
            ce.EventText = "Interview";
            ce.Date = new DateTime(2022, 11, 2, 15, 30, 0);
            ce.EventLengthInHours = 2f;
            ce.RecurringFrequency = RecurringFrequencies.None;
            ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            ce.Enabled = true;
            calendar1.AddEvent(ce);*/

        }

        [CustomRecurringFunction("Get Monday and Wednesday", "Selects the Monday and Wednesday of each month")]
        public bool GetMondayAndWednesday(IEvent evnt, DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Monday || dt.DayOfWeek == DayOfWeek.Wednesday)
                return true;
            return false;
        }

        /// <summary>
        /// 검체등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEvent2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Checked == true)
            {
                    DateTime dt = dateTimePicker1.Value;
                    DateTime dt_time = dateTimePicker2.Value;
           

                Color user_color = colorDialog2.Color;

                if (user_color == Color.Black)
                {
                    user_color = Color.Transparent;
                }
                String user_color_string = user_color.ToString();


                String datetime = dt.ToString("yyyy-MM-dd");
                //String datetime_time = dt_time.ToString("HH:mm:ss");
               // String total_datetime = datetime + " " + datetime_time;
                String total_datetime = datetime;

                var Specimen = new CustomEvent
                {
                    Date = DateTime.Parse(total_datetime),
                    EventText = gum_name.Text,
                    EventColor = user_color,
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("나눔고딕", 10, FontStyle.Regular),
                    Rank = 1,
                    EventTextColor = Color.Black
                };

                    calendar1.AddEvent(Specimen);

                XML_save(gum_name.Text, total_datetime, user_color_string, null, "GumChe");
           
                if (!string.IsNullOrEmpty(gum_name.Text))
                {
                    comboBox1.Items.Add(gum_name.Text);
                }
                gum_name.Text = "";
                dateTimePicker1.Checked = false;
                }
            else
            {
                MessageBox.Show("날짜를 선택하세요");
            }
        }


        /// <summary>
        /// 시험등록 버튼 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_add_Click(object sender, EventArgs e)
        {
           
            DateTime dt = dateTimePicker1.Value;
            DateTime dt_time = dateTimePicker2.Value;

            String datetime = dt.ToString("yyyy-MM-dd");
            //String datetime_time = dt_time.ToString("HH:mm:ss");
            //String total_datetime = datetime + " " + datetime_time;
            String total_datetime = datetime;

            String test_name = testTitle.Text;
            String test_person = comboBox2.SelectedItem.ToString();

            String test = test_name + " - " + test_person;

            Color user_color = colorDialog1.Color;
          
            if(user_color == Color.Black)
            {
                user_color = Color.Transparent;
            }
            String user_color_string = user_color.ToString();
            
            //시험명, 시험자 선택 여부
            if (!String.IsNullOrEmpty(test_name) && comboBox2.SelectedIndex != 0 && comboBox1.SelectedIndex != 0 ) {

                String GumCheName = comboBox1.SelectedItem.ToString();
                
                    var test_case = new CustomEvent
                    {
                        Date = DateTime.Parse(total_datetime),
                        EventText = test,
                        EventColor = user_color,
                        EventLengthInHours = 2f,
                        RecurringFrequency = RecurringFrequencies.None,
                        EventFont = new Font("나눔고딕", 10, FontStyle.Regular),
                        EventTextColor = Color.Black,

                    };

                    calendar1.AddEvent(test_case);
                    XML_save(test, total_datetime, user_color_string, GumCheName, "Test");


                for (int i = 0; i < test_days.CheckedItems.Count; i++)
                {
                    if (test_days.SelectedItem != null)
                    {
                       int day =  Convert.ToInt32(test_days.CheckedItems[i].ToString());
                       
                        //String ppo = Controls["textbox" + i].Text;
                        //MessageBox.Show(ppo);
                        

                        DateTime Added_datetime = dt.AddDays(day);
                        String Added_datetime_string = Added_datetime.ToString();

                        String eventText = Controls["textbox" + day].Text;
                        
                        if(String.IsNullOrEmpty(eventText))
                        {
                           eventText = "계수";
                        }

                        String eventText_Total = test_name+ " " + day + "일차 " + eventText;

                            var added_test_case = new CustomEvent
                            {
                                Date = Added_datetime,
                                EventText = eventText_Total,
                                EventColor = user_color,
                                EventLengthInHours = 2f,
                                RecurringFrequency = RecurringFrequencies.None,
                                EventFont = new Font("나눔고딕", 10, FontStyle.Regular),
                                EventTextColor = Color.Black,

                            };

                            calendar1.AddEvent(added_test_case);
                            XML_save(eventText_Total, Added_datetime_string, user_color_string, GumCheName, "Test");
                    }
                }

                //선택사항 초기화 
                testTitle.Text = "";
                comboBox2.SelectedIndex = 0;
               
                colorDialog1.Color = Color.Transparent;

            } else
            {
                MessageBox.Show("검체명/시험명/시험자를 선택하세요");
            }     
        }


        private void XML_save(String text, String datetime, String color, String GumName, String nodeName) {

            XmlDocument xmlDoc;

            xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFileName);

            if (File.Exists(XmlFileName))
            {
                //검체등록을 누른경우
                
                    try
                    {
                        if (!String.IsNullOrEmpty(text))
                        {
                            XmlNode node = xmlDoc.SelectSingleNode("Root");
                            // XmlElement root = xmlDoc.CreateElement("TestInfo");
                            XmlElement childNode = xmlDoc.CreateElement(nodeName);


                            childNode.SetAttribute("Name", text);
                            childNode.SetAttribute("Datetime", datetime);
                            childNode.SetAttribute("Color", color);
                            childNode.SetAttribute("GumCheName", GumName);

                            node.AppendChild(childNode);
                            //node.AppendChild(root);

                            xmlDoc.Save(XmlFileName);
                            xmlDoc = null;

                        }
                        else
                        {
                            MessageBox.Show("내용을 입력해주세요");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                
            }
            else
            {
                MessageBox.Show("파일이 없어요");
            }
        }

        private void Form1_Load()
        {
           
            try
            {
                if (File.Exists("Data.xml")) {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load( "Data.xml");

                    //xml 속성가져오기
                    XmlNode node = xmlDoc.SelectSingleNode("Root");
                    
                    
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        String nodeName = node.ChildNodes[i].Attributes["Name"].Value.ToString();
                        String datetime = node.ChildNodes[i].Attributes["Datetime"].Value.ToString();
                        String color = node.ChildNodes[i].Attributes["Color"].Value.ToString();

                        Color c;

                        //문자열이 숫자인지아닌지검사
                        Regex r = new Regex("[0-9]");

                        bool isNum = r.IsMatch(color);

                        if (isNum)
                        {
                            Match m = Regex.Match(color, @"A=(?<Alpha>\d+),\s*R=(?<Red>\d+),\s*G=(?<Green>\d+),\s*B=(?<Blue>\d+)");

                            int alpha = int.Parse(m.Groups["Alpha"].Value);
                            int red = int.Parse(m.Groups["Red"].Value);
                            int green = int.Parse(m.Groups["Green"].Value);
                            int blue = int.Parse(m.Groups["Blue"].Value);
                             c = Color.FromArgb(alpha, red, green, blue);

                        } else
                        {                           
                            string real_color = color.Substring(color.IndexOf('[') + 1, color.IndexOf(']') - color.IndexOf('[') - 1);
                            c = Color.FromName(real_color);
                        }

                        var custom = new CustomEvent
                        {
                            Date = DateTime.Parse(datetime),
                            EventText = nodeName,
                            EventColor = c,
                            EventLengthInHours = 2f,
                            RecurringFrequency = RecurringFrequencies.None,
                            EventFont = new Font("나눔고딕", 10, FontStyle.Regular),
                            EventTextColor = Color.Black,
                            
                        };

                        calendar1.AddEvent(custom);

                        

                    }

                    //시험등록 comboBox에 item추가
                    XmlNodeList GumcheNodes = xmlDoc.SelectNodes("Root/GumChe");
                    if (GumcheNodes != null)
                    {
                        foreach (XmlElement GumcheNode in GumcheNodes)
                        {
                            comboBox1.Items.Add(GumcheNode.Attributes["Name"].Value);
                        }
                    }

                } else
                {
                    MessageBox.Show("Xml 파일없는데요");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }


        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void Uncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < test_days.Items.Count; i++)
            {
                test_days.SetItemChecked(i, false);
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog2.Color;
            }
        }
    }
}