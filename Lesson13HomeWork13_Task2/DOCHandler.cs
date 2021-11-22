using System;

namespace Lesson13HomeWork13_Task2
{
    public class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open .doc/.docx format in Word");
        }
        public override void Create()
        {
            Console.WriteLine("Create .doc/.docx format in Word");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge .doc/.docx format in Word");
        }
        public override void Save()
        {
            Console.WriteLine("Save .doc/.docx format in Word");
        }
    }
}
