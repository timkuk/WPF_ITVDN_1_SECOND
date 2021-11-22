using System;
//Создайте четыре метода для выполнения арифметических операций, с именами:
//Add – сложение, Sub – 
//вычитание, Mul – умножение, Div – деление.Каждый метод должен принимать два целочисленных 
//аргумента и выводить на экран результат выполнения арифметической операции соответствующей 
//имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль. 
//Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак 
//арифметической операции, для выполнения вычислений.
namespace Lesson7HomeWork7_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую цифру:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак арифметической операции:");
            string symbol = Convert.ToString(Console.ReadLine());
            Operations operations = new Operations();
            if (symbol == "+")
            {
                Console.WriteLine(operations.Add(a, b));
            }
            else if (symbol == "-")
            {
                Console.WriteLine(operations.Sub(a, b));
            }
            else if (symbol == "*")
            {
                Console.WriteLine(operations.Mul(a, b));
            }
            else if (symbol == "/")
            {
                Console.WriteLine(operations.Div(a, b));
            }
        }
    }
    public class Operations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
