using System;
namespace Lesson33HomeWork33_Task2
{
    public class Forengeits : ConvertationTemperature
    {
        public Forengeits() { }
        public Forengeits(double Temperature)
           : base(Temperature)
        { }
        public override void ConvertTemperature()
        {
            double forengeits = Temperature * 33.8;
            Console.WriteLine($"Температура в Форенгейтах: {forengeits} F");
        }
    }
}
