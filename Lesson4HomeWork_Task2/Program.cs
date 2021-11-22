using System;

namespace Lesson4HomeWork_Task2
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Напишите программу - консольный калькулятор. 
    //Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые
    //произвольные значения.Предложите пользователю ввести знак арифметической операции. Примите
    //значение, введенное пользователем, и поместите его в строковую переменную sign.
    //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch. 
    //Выведите на экран результат выполнения арифметической операции.
    //В случае использования операции деления, организуйте проверку попытки деления на ноль. И если
    //таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке
    //пользователя.
    class Program
    {
        //Все ок , молодец 
        static void Main(string[] args)
        {
            Console.WriteLine("Input meaning first variable:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input meaning first variable:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Plese Input sign of calculation :");
            string sign = Convert.ToString(Console.ReadLine());
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Answer: {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"Answer: {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"Answer: {operand1 * operand2}");
                    break;
                case "%":
                    Console.WriteLine($"Answer: {operand1 % operand2}");
                    break;
                case "/":
                    if (operand2==0)
                    {
                        Console.WriteLine("You can't divide it by zero!");
                    }
                        else
                        {
                            Console.WriteLine($"Answer: {operand1 / operand2}");
                        }
                    break;
                default:
                    Console.WriteLine("Calculate EROR,this sign is not avaliable");
                    break;
            }
        }
    }
}
