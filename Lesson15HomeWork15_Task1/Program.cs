using System;
//Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции.
namespace Lesson15HomeWork15_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers in console");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Calculator.MethodSum(a, b));
            Console.WriteLine(Calculator.MethodMinus(a,b));
            Console.WriteLine(Calculator.MethodMultiplication(a, b));
            Console.WriteLine(Calculator.MethodDivisions(a, b));
        }
    }
}
