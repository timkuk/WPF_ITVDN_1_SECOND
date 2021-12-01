using System;
using System.Collections.Generic;
//Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic
namespace Lesson26HomeWork26_Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input type Operation 1-Adding 2-Substring 3-Multiplicate 4-Division");
            int menu = int.Parse(Console.ReadLine());
            Calculator calculator = new Calculator(12, 0);
            try
            {
                switch (menu)
                {
                    case 1:
                        calculator.Add(calculator.X, calculator.Y);
                        break;
                    case 2:
                        calculator.Sub(calculator.X, calculator.Y);
                        break;
                    case 3:
                        calculator.Mul(calculator.X, calculator.Y);
                        break;
                    case 4:
                        calculator.Del(calculator.X, calculator.Y);
                        break;
                    default:
                        throw new Exception("Menu Exeption!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption!Input true point of menu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

