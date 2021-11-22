using System;
using System.Collections.Generic;
using System.Text;
//Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и деление). 
//Для реализации калькулятора используйте паттерн MVP
namespace Lesson21HomeWork21_Task4
{
    public class Model
    {
        public double MethodSum(string number1, string number2)
        {
            double numberOne = double.Parse(number1);
            double numberTwo = double.Parse(number2);
            double sum = numberOne + numberTwo;
            return sum;
        }
        public double MethodMinus(string number1, string number2)
        {
            double numberOne = double.Parse(number1);
            double numberTwo = double.Parse(number2);
            double minus = numberOne - numberTwo;
            return minus;
        }
        public double MethodMultiplication(string number1, string number2)
        {
            double numberOne = double.Parse(number1);
            double numberTwo = double.Parse(number2);
            double multiplication = numberOne * numberTwo;
            return multiplication;
        }
        public double MethodDivision(string number1, string number2)
        {
            double multiplication = 0;
            double numberOne = double.Parse(number1);
            double numberTwo = double.Parse(number2);
            if (numberTwo != 0)
            {
                 multiplication = numberOne / numberTwo;
            }
            else
            {
                return 0;
            }
            return multiplication;
        }
    }
}
