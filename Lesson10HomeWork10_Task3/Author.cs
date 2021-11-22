using System;

namespace Lesson10HomeWork10_Task3
{
    public class Author
    {
        public string nameAuthor;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine($"Name Author : {nameAuthor}");
            Console.ResetColor();
        }
    }
}
