using System;

namespace Lesson37HomeWork37_Task2
{
    public class Bitcoin : Cripta
    {
        public override void Mining()
        {
            Console.WriteLine("You can mining one bitcoin at week?and you will be rich!");
        }
        public override void ChangeToDollors()
        {
            Console.WriteLine("You can change your coins in cripto changers");
        }
        public override void BuyDrugsFromDarkNet()
        {
            Console.WriteLine("You can buy a lot drugs?but it is bad!");
        }
    }
}
