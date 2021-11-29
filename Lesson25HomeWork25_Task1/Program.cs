using System;
//Создайте структуру описывающую точку в трехмерной системе координат. Организуйте возможность 
//сложения двух точек, через использование перегрузки оператора +.
namespace Lesson25HomeWork25_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2, 3);
            Point point2 = new Point(10, 20, 30);
            Point point3 = point1 + point2;
            Console.WriteLine(point3);
        }
    }
}
