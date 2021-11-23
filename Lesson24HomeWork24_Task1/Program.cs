using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В теле класса создайте четыре метода для арифметических действий: Add – сложение, Sub – вычитание, 
//Mul – умножение, Div – деление.
//Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение. 
//Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.
//При возникновении ошибок должны выбрасываться исключения.
namespace Lesson24HomeWork24_Task1
{
    class Program
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
            catch(Exception e)
            {
                Console.WriteLine("Exeption!Input true point of menu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
