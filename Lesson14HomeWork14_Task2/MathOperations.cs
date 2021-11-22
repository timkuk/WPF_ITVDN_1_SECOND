using System;

namespace Lesson14HomeWork14_Task2
{
    public class MathOperations
    {
        static int massivLength { get; set; }
        public  int[] massiv = new int[massivLength];

        public MathOperations(int massivLength)
        {
            MathOperations.massivLength = massivLength;
        }
        public MathOperations(int[] massiv)
        {
            this.massiv = massiv;
        }
        public void OutPutMassiv(int[] massiv)
        {
            for (int i = 0; i < massivLength; i++)
            {
                Console.WriteLine(massiv[i]);
            }
        }
        public int SumElementArray(int[] massiv)
        {
            int sum = 0;
            for (int i = 0; i < massivLength; i++)
            {
                sum = sum + massiv[i];
            }
            Console.WriteLine($"Вычисление суммы элементов массива : {sum}");
            return sum;
        }
        public int MaxElementOfArray(int[] massiv)
        {
            int a, b = 0;
            for (int i = massiv.Length - 1; i > -1; i--)
            {
                a = massiv[i];

                if (a > b)
                {
                    b = a;
                }
            }
            return b;
        }
        public void MinElementOfArray(int[] massiv)
        {
            MathOperations math = new MathOperations(3);
            int m= math.MaxElementOfArray(massiv);
            Console.WriteLine($"Максимум {m}");
            int t = 0;
            for (int j = massiv.Length - 1; j > -1; j--)
            {
                t = massiv[j];

                if (t < m)
                {
                    m = t;
                }
            }
            Console.WriteLine($"Минимум {m}");
            Console.WriteLine("Список всех элементов массива:");
            Console.WriteLine(string.Join(" ", massiv));
        }

        public void SearchOddNumber(int[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] % 2 != 0)
                {
                    Console.WriteLine($"Число явлется нечетным : {massiv[i]}");
                }
            }
        }
        
       public void ArithmeticMean(int[] massiv)
        {
            MathOperations math = new MathOperations(3);
            int sum=math.SumElementArray(massiv);
            double average = sum / massiv.Length;
            Console.WriteLine($"Вычисление среднего арифметического элеметов массива : {average}");
        }
    }
}
