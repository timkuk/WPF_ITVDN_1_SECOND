using System;

namespace Lesson37HomeWork37_Task2
{
    public class Ephirium : Cripta
    {
        public override void Mining()
        {
            Console.WriteLine("You can mining one Ephirium at week?and you will be rich!");
        }
        public override void ChangeToDollors()
        {
            Console.WriteLine("You can change your Ephirium in cripto changers");
        }
        public override void BuyDrugsFromDarkNet()
        {
            Console.WriteLine("You can buy a lot drugs using Ephirium,but it is bad!");
        }
    }
}
