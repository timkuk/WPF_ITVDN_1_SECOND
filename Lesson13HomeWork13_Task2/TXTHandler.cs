using System;

namespace Lesson13HomeWork13_Task2
{
    public class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open .txt format in WordPad");
        }
        public override void Create()
        {
            Console.WriteLine("Create .txt format in WordPad");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge .txt format in WordPad");
        }
        public override void Save()
        {
            Console.WriteLine("Save .txt format in WordPad");
        }
    }
}
