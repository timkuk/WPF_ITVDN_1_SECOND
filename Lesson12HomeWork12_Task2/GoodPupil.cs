using System;

namespace Lesson12HomeWork12_Task2
{
    public class GoodPupil : Pupil
    {
        public string goodPupil { get; set; }
        public GoodPupil(string goodPupil)
        {
            this.goodPupil = goodPupil;
        }
        public override void Study()
        {
            Console.WriteLine("This pupil  good study");
        }
        public override void Read()
        {
            Console.WriteLine("This pupil good read");
        }
        public override void Write()
        {
            Console.WriteLine("This pupil good write");
        }
        public override void Relax()
        {
            Console.WriteLine("This pupil normal relaxing");
        }
    }
}
