using System;

namespace Lesson12HomeWork12_Task2
{
    public class BadPupil : Pupil
    {
        public string badPupil { get; set; }
        public BadPupil(string badPupil)
        {
            this.badPupil = badPupil;
        }
        public override void Study()
        {
            Console.WriteLine("This pupil bad study");
        }
        public override void Read()
        {
            Console.WriteLine("This pupil bad read");
        }
        public override void Write()
        {
            Console.WriteLine("This pupil bad write");
        }
        public override void Relax()
        {
            Console.WriteLine("This pupil good relaxing  and drinks bear");
        }
    }
}
