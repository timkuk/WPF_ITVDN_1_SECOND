using System;
using System.Text;
//Имеется N клиентов, которым компания производитель должна доставить товар. Сколько существует 
//возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина? 
//Напишите программу, которая будет рассчитывать и выводить на экран количество возможных 
//вариантов доставки товара. Для решения задачи, используйте факториал N!, рассчитываемый с 
//помощью рекурсии. Объясните, почему не рекомендуется использовать рекурсию для расчета 
//факториала. Укажите слабые места данного подхода.
namespace Lesson8HomeWork8_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Input number clients:");
            int numberClients = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.Factorial(numberClients);
        }
        public void Factorial(int numberClients)
        {
            int counter = numberClients;
            int factorial = 1;
            Console.Write($"The number of possible delivery options: {counter} = ");
            do
            {
                factorial *= counter--;
            }
            while (counter > 0);
            Console.WriteLine(factorial);
        }
    }
}
