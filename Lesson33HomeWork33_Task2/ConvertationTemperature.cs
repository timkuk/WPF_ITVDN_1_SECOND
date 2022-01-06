using System;

namespace Lesson33HomeWork33_Task2
{
    public abstract class ConvertationTemperature
    {
        public double Temperature { get; set; }
        protected EnumTranslate state;
        protected ConvertationTemperature()
        {
            state = EnumTranslate.No;
        }
        protected ConvertationTemperature(double Temperature): this()
        {
            this.Temperature = Temperature;
        }
        public abstract void ConvertTemperature();
    }
}
