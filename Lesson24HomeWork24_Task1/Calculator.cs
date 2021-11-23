using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В теле класса создайте четыре метода для арифметических действий: Add – сложение, Sub – вычитание, 
//Mul – умножение, Del – деление.
//Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение. 
//Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.
//При возникновении ошибок должны выбрасываться исключения.
namespace Lesson24HomeWork24_Task1
{
    public class Calculator
    {
        public  double X { get; set; }
        public double Y { get; set; }

        public Calculator(double x,double y)
        {
            X = x;
            Y = y;
        }
        public void Add(double x,double y)
        {
            double add = x - y;
            Console.WriteLine(add);
        }
        public void Sub(double x, double y)
        {
            double sub = x - y;
            Console.WriteLine(sub);
        }
        public void Mul(double x, double y)
        {
            double multiplicate = x * y;
            Console.WriteLine(multiplicate);
        }
        public void Del(double x, double y)
        {
            try
            {
                if (y != 0)
                {
                    double del = x / y;
                    Console.WriteLine(del);
                }
                else
                {
                    throw new Exception("Division Exeption!Second argument must not zero!Fix it!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
