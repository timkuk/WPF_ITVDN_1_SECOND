using System;
using System.Collections.Generic;
//Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic
namespace Lesson26HomeWork26_Task1
{
    public class Calculator
    {
        public dynamic X { get; set; }
        public dynamic Y { get; set; }

        public Calculator(dynamic x, dynamic y)
        {
            X = x;
            Y = y;
        }
        public void Add(dynamic x, dynamic y)
        {
            dynamic add = x - y;
            Console.WriteLine(add);
        }
        public void Sub(dynamic x, dynamic y)
        {
            double sub = x - y;
            Console.WriteLine(sub);
        }
        public void Mul(dynamic x, dynamic y)
        {
            dynamic multiplicate = x * y;
            Console.WriteLine(multiplicate);
        }
        public void Del(dynamic x, dynamic y)
        {
            try
            {
                if (y != 0)
                {
                    dynamic del = x / y;
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
