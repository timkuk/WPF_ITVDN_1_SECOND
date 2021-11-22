using System;

namespace Lesson4HomeWork4_Task3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    //    Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой
    //промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток.Если
    //пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то
    //выводится соответствующее сообщение.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input point on the interval:");
            double point = Convert.ToDouble(Console.ReadLine());
            if (point>=0 && point <=14)
            {
                Console.WriteLine($"This point on the interval : [0-14]");
            }
                else if(point >= 15 && point <= 35)
                {
                    Console.WriteLine($"This point on the interval : [15-35]");
                }
                    else if (point >= 36 && point <=50)
                    {
                        Console.WriteLine($"This point on the interval : [36-50]:");
                    }
                        else if (point >= 50 && point <= 100)
                        {
                             Console.WriteLine($"This point on the interval : [50-100]:");
                        }
                            else
                            {
                                Console.WriteLine($"This point not on this interval !");
                            }
        }
    }
}
