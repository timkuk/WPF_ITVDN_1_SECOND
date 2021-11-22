using System;

//Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
namespace Lesson6HomeWork6_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Enter number A");
            int A = Convert.ToInt32(Console.ReadLine());//2
            Console.WriteLine("Enter number B");
            int B = Convert.ToInt32(Console.ReadLine());//10
            int sum = 0;
            int argument = B - A ;
            for (int i = 1; i < argument; i++)
            {
                sum = sum + A + i;
            }
            Console.WriteLine($"All sum numbers from the range: {sum}");
            #endregion

            #region Task 2
            Console.WriteLine("All odd numbers from the range");
            for (int i = 1; i < argument; i++)
            {
                int varible = A + i;
                if (varible%2 != 0)
                {
                    int odd =A + i;
                    Console.WriteLine(odd);
                }
            }
            #endregion
        }
    }
}
