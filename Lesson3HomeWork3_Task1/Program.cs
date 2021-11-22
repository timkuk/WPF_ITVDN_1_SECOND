using System;

namespace Lesson3HomeWork3_Task1
{
    /////Используя VisualStudio, создайте проект по шаблону ConsoleApplication. 
    //Создайте две целочисленные переменные и выведите на экран результаты всех арифметических
    //операций над этими двумя переменными.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = -122;
            int c,e,d,f,g,h;
            c= a - b;
            e = a + b;
            d = a / b;
            f = a * b;
            g = a % b;
            h = ++a - b++;

            Console.WriteLine($"Out Put :{c} {e} {d} {f} {g} {h}");
        }
    }
}
