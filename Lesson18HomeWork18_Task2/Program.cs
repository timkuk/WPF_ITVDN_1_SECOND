using System;
//Создайте четыре лямбда оператора для выполнения арифметических действий:
//(Add – сложение, Sub –вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два 
//аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль. 
//Написать программу, которая будет выполнять арифметические действия, указанные пользователем.
namespace Lesson18HomeWork18_Task2
{
    public delegate double DelegateForLambda(double a, double b);
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers for calculating:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int menu = 0;
            while (menu < 4)
            {
                Console.WriteLine("Input type operations : \n 0-Exit -выход \n 1-Add – сложение \n 2-Sub –вычитание \n 3-Mul – умножение, \n 4-Div – деление");
                int typeOperation = int.Parse(Console.ReadLine());
                DelegateForLambda delegateForLambda;
                if (typeOperation == 0)
                {
                    break;
                }
                else
                {
                    switch (typeOperation)
                    {
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        case 1:
                            delegateForLambda = (a, b) => a + b;
                            Console.WriteLine(delegateForLambda(a, b));
                            break;
                        case 2:
                            delegateForLambda = (a, b) => a - b;
                            Console.WriteLine(delegateForLambda(a, b));
                            break;
                        case 3:
                            delegateForLambda = (a, b) => a * b;
                            Console.WriteLine(delegateForLambda(a, b));
                            break;
                        case 4:
                            delegateForLambda = (a, b) => b != 0 ? a / b : 0;
                            Console.WriteLine(delegateForLambda(a, b));
                            break;
                        default:
                            Console.WriteLine("Exit");
                            break;
                    }
                }
            }
        }
    }
}
