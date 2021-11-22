using System;
//Создайте одномерные массивы целочисленных элементов всеми известными вам способами. Заполните их элементами. Выведите на экран все элементы массивов.
namespace Lesson9HomeWork9_DopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //Задаём случайный размер от 2х2 до 10х10
            int r = random.Next(2, 11);
            int[,] Matrix = new int[r, r];
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }

            //Выводим матрицу на экран
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
