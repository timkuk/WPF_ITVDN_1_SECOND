using System;

namespace Lesson37HomeWork37_Task1
{
    public class Programmist
    {
        public void Coding()
        {
            CodingOnC();
            CodingOnJava();
        }
        protected virtual void CodingOnC() { Console.WriteLine("You good programmist!"); }
        protected void CodingOnJava() { Console.WriteLine("You pidor!"); }
    }
}
