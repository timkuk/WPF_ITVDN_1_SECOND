using System;

//Создайте две целочисленные переменные и задайте им некоторые значения. Применяя технику 
//вложенных циклов, нарисуйте прямоугольник из звездочек. Используйте значения ранее созданных 
//переменных для указания высоты и ширины прямоугольника.
namespace Lesson6HomeWork6_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight figure");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hight figure");
            int hight = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hight; i++)
            {
                if (i == 0 || i == hight-1 )
                {
                    for (int j = 0; j < weight; j++)
                    {
                        Console.Write("*");
                    }
                }
                if(i>=1)
                {
                    if (i != hight - 1)
                    {
                        Console.Write(new string('*', weight - (weight-1)) + new string(' ', weight - 2) + new string('*', weight - (weight - 1)));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
