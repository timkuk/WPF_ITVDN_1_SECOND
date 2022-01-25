using System;
using System.Threading;
//Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10 итераций) 
//увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток 
//Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в 
//результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в произвольном порядке
namespace Lesson38HomeWork38_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting result : ");
            for(int i =1; i < 31; i++)
            {
                Console.Write($"\t{i}");
            }
            Bloker bloker = new Bloker();
            Thread[] threads = new Thread[3];
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                (threads[i] = new Thread(bloker.Prozessor)).Start(i+1);
            }     
        }
    }
}
