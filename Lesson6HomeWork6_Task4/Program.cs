using System;
using System.Text;
//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?
//Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
//Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.
namespace Lesson6HomeWork6_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Input number clients:");
            int numberClients = Convert.ToInt32(Console.ReadLine());
            int counter = numberClients;
            int factorial = 1;

            Console.Write($"The number of possible delivery options: {counter} = ");

            do
            {
                // Сначала умножение, потом декремент. 
                factorial *= counter--;
            }
            while (counter > 0);
            Console.WriteLine(factorial);
        }
    }
}
