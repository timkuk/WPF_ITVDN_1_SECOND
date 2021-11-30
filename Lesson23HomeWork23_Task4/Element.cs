using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23HomeWork23_Task4
{
    public class Element<T> :MyList<T>
    {
        private int number;

        public Element(int s,int length) : base(length)
        {
            number = s;
        }

        public int Field1
        {
            get { return number; }
            set { number = value; }
        }
        public override string ToString()
        {
            return $"Значение {Field1}";
        }
    }
}

