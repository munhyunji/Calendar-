using System;
using System.Drawing;
using System.Windows.Forms;
using Calendar.NET;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;


namespace Calendar.NETDemo
{
    public partial class Form1 : Form

    {
       
        String XmlFileName = "Data.xml";

        public Form1()
        {
            InitializeComponent();
            
            calendar1.CalendarDate = DateTime.Today;
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;

            dateTimePicker1.Format = DateTimePickerFormat.Long;//날짜 + 시간 형태

            Form1_Load();

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
                //DateTime dt_time = dateTimePicker2.Value;

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
                String GumCheName = gum_name.Texts.Trim();

                var Specimen = new CustomEvent
                {
                    Date = DateTime.Parse(total_datetime),
                    EventText = GumCheName,
                    EventColor = user_color,
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("나눔고딕", 8, FontStyle.Regular),
                    Rank = 1,
                    EventTextColor = Color.Black
                };

                calendar1.AddEvent(Specimen);

                int IsSuccess = XML_save(GumCheName, null, total_datetime, user_color_string, null, null, null, "GumChe");

                
                //XML저장이 성공했을시에만...!! 
               /* if (IsSuccess == 0 )
                    {
                    if (File.Exists(XmlFileName))
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(XmlFileName);

                        //xml 속성가져오기
                        XmlNodeList node = xmlDoc.SelectNodes("Root/GumChe");


                        comboBox1.Items.Add("("+total_datetime+") "+ GumCheName);
                    }
                    
                }*/

                gum_name.Texts = "";
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
            
            //시험일자
            String datetime = dt.ToString("yyyy-MM-dd");
            //String datetime_time = dt_time.ToString("HH:mm:ss");
            //String total_datetime = datetime + " " + datetime_time;
            String total_datetime = datetime;

            //시험명
            String test_name = testTitle.Texts;
            int test_name_len = test_name.Length;
            
            //시험자
            String test_person = comboBox2.SelectedItem.ToString();

            if (test_person == "시험자를 선택하세요.")
            {
                test_person = "빈값";
            }

            String test = "【" + test_person + "】 " + test_name;
         
            String aligned_test = TextAlignCenter_TestName(test);

            //검체량
            String GumAmt = gum_amt.Texts;

            Color user_color = colorDialog2.Color;

            if (user_color == Color.Black)
            {
                user_color = Color.Transparent;
            }
            String user_color_string = user_color.ToString();

            //시험명, 선택 여부
            // 시험자 선택여부 제거 230202
            if (!String.IsNullOrEmpty(test_name) && comboBox1.SelectedIndex != 0 ) {

                String GumCheInfo = comboBox1.SelectedItem.ToString();
                String GumCheDate = GumCheInfo.Substring(1, 10);
                String GumCheName = GumCheInfo.Substring(12).TrimStart();

                var test_case = new CustomEvent
                {
                    Date = DateTime.Parse(total_datetime),
                    EventText = aligned_test,
                    EventColor = user_color,
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("나눔고딕", 8, FontStyle.Regular),
                    Rank = 2,
                    EventTextColor = Color.Black,

                };

                calendar1.AddEvent(test_case);
                XML_save(test, null, total_datetime, user_color_string, GumCheName, GumCheDate, GumAmt, "Test");


                for (int i = 0; i < test_days.CheckedItems.Count; i++)
                {
                    if (test_days.SelectedItem != null)
                    {
                        int day = Convert.ToInt32(test_days.CheckedItems[i].ToString());

                        Control ppo = Controls.Find("rjTextBox" + day, true)[0];

                        String eventText = ((CustomControls.RJControls.RJTextBox)ppo).Texts;

                        //MessageBox.Show(tt);

                        DateTime Added_datetime = dt.AddDays(day);
                        String Added_datetime_string = Added_datetime.ToString("yyyy-MM-dd");

                        if (string.IsNullOrEmpty(eventText))
                        {
                            eventText = "계수";
                        }
                       
                        String DaysText = day + "일차 " + eventText;
                       
                        String total = aligned_test + "\n" +  TextAlignCenter_DaysName(test, DaysText);
                        
                        var added_test_case = new CustomEvent
                        {
                            Date = Added_datetime,
                            EventText = total,
                            EventColor = user_color,
                            EventLengthInHours = 2f,
                            RecurringFrequency = RecurringFrequencies.None,
                            EventFont = new Font("나눔고딕", 8, FontStyle.Regular),
                            Rank = 3,
                            EventTextColor = Color.Black
                            
                        };

                        calendar1.AddEvent(added_test_case);
                        XML_save(test, DaysText, Added_datetime_string, user_color_string, GumCheName, GumCheDate, GumAmt, "Test");


                        //textbox 초기화
                        ((CustomControls.RJControls.RJTextBox)ppo).Texts = "";
                    }
                }

                //선택사항 초기화 
                testTitle.Texts = "";
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                gum_amt.Texts = "";
                Uncheck_Click(null, null);
                //colorDialog2.Color = Color.Transparent;
                //panel2.BackColor = Color.Transparent;

            } else
            {
                MessageBox.Show("검체명/시험명을 선택하세요");
            }
        }


        private int XML_save(String text, String textDate, String datetime, String color, String GumCheName, String GumCheDate, String GumAmt, String nodeName) {

            XmlDocument xmlDoc;

            xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFileName);

            if (File.Exists(XmlFileName))
            {
              
                    try
                    {
                        if (!String.IsNullOrEmpty(text))
                        {
                            XmlNode node = xmlDoc.SelectSingleNode("Root");
                            // XmlElement root = xmlDoc.CreateElement("TestInfo");
                            XmlElement childNode = xmlDoc.CreateElement(nodeName);
                        
                        //검체인경우
                        if (nodeName == "GumChe") {
                            childNode.SetAttribute("Name", text);
                            childNode.SetAttribute("Datetime", datetime);
                            childNode.SetAttribute("Color", color);
                            childNode.SetAttribute("GumAmt", GumAmt);
                            childNode.SetAttribute("Rank", "1");

                        //시험명인경우  
                        } else if(nodeName == "Test" && textDate == null)
                        {
                            childNode.SetAttribute("Name", text);
                            childNode.SetAttribute("Datetime", datetime);
                            childNode.SetAttribute("Color", color);
                            childNode.SetAttribute("GumCheName", GumCheName);
                            childNode.SetAttribute("GumCheDate", GumCheDate);
                            childNode.SetAttribute("GumAmt", GumAmt);
                            childNode.SetAttribute("Rank", "2");

                        //시험명+일차 인경우
                        } else
                        {
                            childNode.SetAttribute("Name", text);
                            childNode.SetAttribute("NameDate", textDate);
                            childNode.SetAttribute("Datetime", datetime);
                            childNode.SetAttribute("Color", color);
                            childNode.SetAttribute("GumCheName", GumCheName);
                            childNode.SetAttribute("GumCheDate", GumCheDate);
                            childNode.SetAttribute("GumAmt", GumAmt);
                            childNode.SetAttribute("Rank", "3");
                        }

                            node.AppendChild(childNode);
                            //node.AppendChild(root);

                            xmlDoc.Save(XmlFileName);
                            xmlDoc = null;
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("내용을 입력해주세요");
                            return 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return 1;
                }
                
            }
            else
            {
                MessageBox.Show("파일이 없어요");
                return 1;
            }
        }

        private void Form1_Load()
        {
           
            try
            {
                if (File.Exists(XmlFileName)) {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(XmlFileName);

                    //xml 속성가져오기
                    XmlNode node = xmlDoc.SelectSingleNode("Root");
                                     
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        // attribute 존재하는지  검사 
                        String nodeName;

                        if (node.ChildNodes[i].Attributes.GetNamedItem("NameDate") == null)
                        {
                             nodeName = node.ChildNodes[i].Attributes["Name"].Value.ToString();

                        }
                        else
                        {
                             nodeName = node.ChildNodes[i].Attributes["Name"].Value.ToString() + "\n" + TextAlignCenter_DaysName(node.ChildNodes[i].Attributes["Name"].Value.ToString(), node.ChildNodes[i].Attributes["NameDate"].Value);

                        }
                      
                        String datetime = node.ChildNodes[i].Attributes["Datetime"].Value.ToString();
                        String color = node.ChildNodes[i].Attributes["Color"].Value.ToString();
                        int rank = Int32.Parse(node.ChildNodes[i].Attributes["Rank"].Value.ToString());

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
                            EventFont = new Font("나눔고딕", 8, FontStyle.Regular),
                            EventTextColor = Color.Black,
                            Rank = rank
                            
                        };

                        calendar1.AddEvent(custom);                       

                    }

                    //시험등록 comboBox에 item추가
                    XmlNodeList GumcheNodes = xmlDoc.SelectNodes("Root/GumChe");
                    if (GumcheNodes != null)
                    {
                        foreach (XmlElement GumcheNode in GumcheNodes)
                        {
                            comboBox1.Items.Add("(" + GumcheNode.Attributes["Datetime"].Value +") " + GumcheNode.Attributes["Name"].Value);
                        }
                    }


                } else
                {
                    MessageBox.Show("Xml 파일이 존재하지않습니다.");
                }

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
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
           
            DaysName =  DaysName.PadLeft(TestName.Length+1);
            
            return DaysName;
        }


        private String TextAlignCenter_TestName(String TestName)
        {

            TestName = TestName.PadLeft(TestName.Length+1);

            return TestName;
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

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(XmlFileName))
            {
                //콤보박스 초기화
                comboBox1.Items.Clear();
                comboBox1.Items.Add("검체를 선택하세요.");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFileName);

                //시험등록 comboBox에 item추가
                XmlNodeList GumcheNodes = xmlDoc.SelectNodes("Root/GumChe");

                    if (GumcheNodes != null)
                    {
                        foreach (XmlElement GumcheNode in GumcheNodes)
                        {
                            if (GumcheNode.Attributes["Name"].Value != "")
                            {
                            comboBox1.Items.Add("(" + GumcheNode.Attributes["Datetime"].Value + ") " + GumcheNode.Attributes["Name"].Value);
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Data 파일을 찾을수없습니다.");
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            calendar1.RemoveAllEvent();           
            Form1_Load();
        }

    }
}
