using System;

namespace Lesson10HomeWork10_Task3
{
    public class Book
    {
        public string title, author, content;

        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Title Book: {title} Name Author: {author} Content: {content}");
            Console.ResetColor();
        }
    }
}
