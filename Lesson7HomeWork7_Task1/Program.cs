using System;
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных 
//аргумента и выводит на экран среднее арифметическое значений аргументов.
namespace Lesson7HomeWork7_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator program = new Calculator();
            Console.WriteLine("Arithmetic mean:");
            Console.WriteLine(program.Calculate(12,24,25));
        }
    }
    public class Calculator
    {
        public double Calculate(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
