using System;
//Известно, что у четных чисел младший бит имеет значение 0. 
//Напишите программу, которая будет выполнять проверку чисел на четность. 
//Предложите два варианта решения поставленной зад
namespace Lesson5HomeWork5_Task2
{
    //число нечетно, когда его младший бит равен 1, и четно, когда младший бит равен 0
    class Program
    {
        static void Main(string[] args)
        {
            #region [First Method]
            Console.WriteLine("Enter integer number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first method");
            double remains = number % 2;
            if (remains == 0)
            {
                Console.WriteLine($"This number even: {number}");
            }
            else
            {
                Console.WriteLine($"This number uneven: {number}");
            }
            Console.WriteLine("The second method");
            #endregion

            //Выражение i & 1 выполняет побитовую операцию "И" между соответствующими
            //битами обоих чисел
            #region [Second Method]
            if ((number & 1) != 1)
            {
                Console.WriteLine($"This number even: {number}");
            }
            else
            {
                Console.WriteLine($"This number uneven: {number}");
            }
            #endregion
        }
    }
}
