using System;

namespace Lesson3HomeWork3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для подсчёта среднего арифметического лучше использовать тип данных double т.к у него повышенная точность
            int a,b,c;
            a = 195;
            b = 144;
            c = 4242;
            double s = (a+b+c)/3;
            Console.WriteLine(s);
        }
    }
}
