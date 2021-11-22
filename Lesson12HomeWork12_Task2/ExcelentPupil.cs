using System;

namespace Lesson12HomeWork12_Task2
{
    public class ExcelentPupil : Pupil
    {
        public string excelentPupil { get; set; }
        public ExcelentPupil(string excelentPupil)
        {
            this.excelentPupil = excelentPupil;
        }
        public override void Study()
        {
            Console.WriteLine("This pupil  excelent study");
        }
        public override void Read()
        {
            Console.WriteLine("This pupil excelent read");
        }
        public override void Write()
        {
            Console.WriteLine("This pupil excelent write");
        }
        public override void Relax()
        {
            Console.WriteLine("This pupil bad relaxing");
        }
    }
}
