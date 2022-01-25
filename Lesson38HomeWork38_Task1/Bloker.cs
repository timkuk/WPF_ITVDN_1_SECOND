using System;
using System.Threading;
//Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10 итераций) 
//увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток 
//Метод запускается в трех потоках. Каждый поток должен выполниться поочередно,в 
//результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в произвольном порядке
namespace Lesson38HomeWork38_Task1
{
    public class Bloker
    {
        public static long counter;
        static object block = new object();
        public  void Prozessor(object barsi)
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    counter++;
                    Console.WriteLine($"\t{counter} Number Thread {barsi}");
                }
            }
        }
    }
}
