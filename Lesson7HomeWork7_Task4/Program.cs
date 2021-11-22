using System;
//Напишите метод, который будет определять: 
//1) является ли введенное число положительным или отрицательным. 
//2) Является ли оно простым (используйте технику перебора значений). 
//(Простое число – это натуральное число, которое делится на 1 и само на себя. Чтобы определить
//простое число или нет, следует найти все его целые делители. Если делителей больше 2-х, значит оно не простое.)
//3) Делится ли на 2, 5, 3, 6, 9 без остатка.
namespace Lesson7HomeWork7_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.IsItPositiveNumber(number));
            Console.WriteLine(calculator.Division(number));
            calculator.IsItSimpleNumber(number);
        }
    }
    public class Calculator
    {
        public string IsItPositiveNumber(int number)
        {
            if (number < 0)
            {
                return "Число отрицательное";
            }
            else
            {
                return "Число положительное";
            }
        }
        public void IsItSimpleNumber(int number)
        {
            bool prost = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
        public string Division(int number)
        {
            //1620
            if ((number % 2) == 0 && (number % 5) == 0 && (number % 3) == 0 && (number % 6) == 0 && (number % 9) == 0)
            {
                return $"Число делится на 2 5 3 6 9 без остатка";
            }
            return $"Число  НЕ делится на 2 5 3 6 9 без остатка";
        }
    }
}
