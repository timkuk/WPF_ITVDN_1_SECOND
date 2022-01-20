using System;
//Реализуйте шаблон NVI в собственной иерархии наследования
namespace Lesson37HomeWork37_Task1
{
    public class  Program
    {
        static void Main(string[] args)
        {
            Programmist programmist = new Computer();
            programmist.Coding();
            Programmist computer = new Programmist();
            computer.Coding();
        }
    }
}
