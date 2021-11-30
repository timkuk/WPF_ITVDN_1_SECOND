using System;
using System.Collections.Generic;

namespace Lesson23HomeWork23_Task2
{
    public class Element
    {
        private int number;

        public Element(int s)
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
