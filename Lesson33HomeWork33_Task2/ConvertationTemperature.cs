using System;

namespace Lesson33HomeWork33_Task2
{
    public abstract class ConvertationTemperature
    {
        public double Temperature { get; set; }
        public EnumTranslate state;
        public ConvertationTemperature()
        {
            state = EnumTranslate.No;
        }
        public ConvertationTemperature(double Temperature): this()
        {
            this.Temperature = Temperature;
        }
        public abstract void ConvertTemperature();
    }
}
