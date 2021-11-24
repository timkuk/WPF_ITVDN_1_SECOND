using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24HomeWork24_Task2
{
    public class StudentComparer : IComparer<Worker>
    {
        public int Compare(Worker a, Worker b)
        {
            return a.Sername.CompareTo(b.Sername);
        }
    }
}
