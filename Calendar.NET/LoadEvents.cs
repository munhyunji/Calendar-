using Calendar.NET;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Calendar.NET
{
    class LoadEvents
    {
        
        private IEvent _newEvent;

        XmlDocument xmlDoc;
        String XmlFileName = "Data.xml";

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }

        public void Form1_Load()
        {

            try
            {
                if (File.Exists(XmlFileName))
                {
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

                        }
                        else
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

                        Calendar cal = new Calendar();
                        cal.AddEvent(custom);

                    }
                }
                else
                {
                    MessageBox.Show("Xml 파일이 존재하지않습니다.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private String TextAlignCenter_DaysName(String TestName, String DaysName)
        {

            DaysName = DaysName.PadLeft(TestName.Length + 1);

            return DaysName;
        }


        private String TextAlignCenter_TestName(String TestName)
        {

            TestName = TestName.PadLeft(TestName.Length + 1);

            return TestName;
        }

    }
}
