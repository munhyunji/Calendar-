using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.NETDemo
{
    public sealed class MyListBox:CheckedListBox
    {
        public MyListBox()
        {
            ItemHeight = 23;
        }
        public override int ItemHeight { get; set; }


    }
}
