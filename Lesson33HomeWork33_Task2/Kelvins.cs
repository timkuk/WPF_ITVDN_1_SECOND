using System;
namespace Lesson33HomeWork33_Task2
{
    
    public class Kelvins : ConvertationTemperature 
    {
        public Kelvins() { }
        public Kelvins(double Temperature) : base(Temperature)
        {
        }
        public override void ConvertTemperature()
        {
            double forengeits = Temperature + 274 ;
            Console.WriteLine($"Температура в Кельвинах: {forengeits}К");
        }
    }
}
