using System;

namespace Lesson10HomeWork10_Task3
{
    public class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title Book : {title}");
            Console.ResetColor();
        }
    }
}
