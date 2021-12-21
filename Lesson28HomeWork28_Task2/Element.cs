using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28HomeWork28_Task2
{
    public class Element
    {
        public string NameMonth { get; set; }
        public int CountDays { get; set; }
        public int SerialNumber { get; set; }
        public Element(string NameMonth,int CountDays, int SerialNumber)
        {
            this.NameMonth = NameMonth;
            this.CountDays = CountDays;
            this.SerialNumber = SerialNumber;
        }

    }
}
