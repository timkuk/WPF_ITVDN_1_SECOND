using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Напишите программу, в которой метод будет вызываться рекурсивно
//Каждый новый вызов метода выполняется в отдельном потоке.
namespace Lesson22HomeWork22_Task1
{
    public class Program
    {
        static void RecursionMethod2()
        {
            Console.WriteLine("RecursionMethod2 Method Working!");
        }
        static void RecursionMethod()
        {
            Console.WriteLine("RecursionMethod Method Working!");
        }
        /// <summary>
        /// Вызов метода из метода (реализация рекурсии)Для теста написал два метода для тестирования потоков
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Input number calling Recursion Method:");
            int count =int.Parse(Console.ReadLine());
            ThreadStart threadStart = new ThreadStart(RecursionMethod);
            ThreadStart threadStart2 = new ThreadStart(RecursionMethod2);
            int i = 0;
            while (i<count)
            {
                Thread thread2 = new Thread(threadStart2);
                thread2.Start();
                Thread thread = new Thread(threadStart);
                thread.Start();
                i++;
            }
        }
    }
}
