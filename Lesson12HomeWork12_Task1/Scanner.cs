using System;

namespace Lesson12HomeWork12_Task1
{
    public class Scanner : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
