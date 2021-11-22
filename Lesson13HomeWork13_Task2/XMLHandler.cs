using System;

namespace Lesson13HomeWork13_Task2
{
    public class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open .xml format in Visual Studio");
        }
        public override void Create()
        {
            Console.WriteLine("Create .xml format in Visual Studio");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge .xml format in Visual Studio");
        }
        public override void Save()
        {
            Console.WriteLine("Save .xml format in Visual Studio");
        }
    }
}
