using System;

namespace Lesson10HomeWork10_Task3
{
    public class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Content : {content}");
            Console.ResetColor();
        }
    }
}
