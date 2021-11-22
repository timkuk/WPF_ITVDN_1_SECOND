using System;

namespace Lesson3HomeWork3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double  pi = Math.PI;
            Console.WriteLine("Input Radius");
            double r = Console.Read();
            double S = pi * Math.Pow(r,2);
            Console.WriteLine(S);
        }
    }
}
