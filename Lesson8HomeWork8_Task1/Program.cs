using System;
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных 
//значения и возвращает значение каждого аргумента деленного на 5.
namespace Lesson8HomeWork8_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            calculator.Calculate(a, b, c);
        }
    }
    public class Calculator
    {
        /// <summary>
        /// Realization method of division with numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Calculate(int a, int b , int c)
        {
            double k = a / 5;
            double f = b / 5;
            double g = c / 5;
            Console.WriteLine($"Результат деления на 5 a: {k} , b: {f} , c: {g}");
        }
    }
}
