using System;
namespace Lesson33HomeWork33_Task2
{
    [TemperatureAtribute(123)]
    public class Forengeits : ConvertationTemperature
    {
        [TemperatureAtribute(121243)]
        public Forengeits() { }
        public Forengeits(double Temperature)
           : base(Temperature)
        { }
        [TemperatureAtribute(1223133)]
        public override void ConvertTemperature()
        {
            double forengeits = Temperature * 33.8;
            Console.WriteLine($"Температура в Форенгейтах: {forengeits} F");
        }
    }
}
