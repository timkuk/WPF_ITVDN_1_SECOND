using System;

namespace Lesson3HomeWork3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Супер )))
            double pi = Math.PI;
            Console.WriteLine("Input Radius ");
            double radius = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("Input Higth");
            double height = Convert.ToDouble((Console.ReadLine()));
            double volume = pi * Math.Pow(radius, 2) * height;
            double square = 2 * pi * radius * height * 2 * pi * Math.Pow(radius, 2);
            Console.WriteLine(new string('_', 25));
            Console.WriteLine($"Volume {volume}");
            Console.WriteLine($"Square:{square}");
        }
    }
}
