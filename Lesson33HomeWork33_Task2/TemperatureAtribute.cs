using System;

namespace Lesson33HomeWork33_Task2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class TemperatureAtribute : System.Attribute
    {
        public int Temperaturka { get; set; }
        public TemperatureAtribute(int temperaturka)
        {
            temperaturka = Temperaturka;
        }
    }
}
