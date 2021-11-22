using System;
//Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер массива задает пользователь). 
//Вывести на экран: наибольшее значение массива, наименьшее значение массива,
//+общую сумму всех элементов, +среднее арифметическое всех элементов, +вывести все нечетные значения.
namespace Lesson9HomeWork9_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[N];
            Console.WriteLine("Введите элементы массива");
            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
                sum = sum + massiv[i];
            }
            Console.WriteLine($"Вычисление суммы элементов массива : {sum}");
            //Наибольшее значение массива
            int a, b = 0;
            for (int i = massiv.Length - 1; i > -1; i--)
            {
                a = massiv[i];

                if (a > b)
                {
                    b = a;
                }
            }
            Console.WriteLine($"Максимум {b}");

            //Наименьшее значение массива
            for (int j = massiv.Length - 1; j > -1; j--)
            {
                a = massiv[j];

                if (a < b)
                {
                    b = a;
                }
            }
            Console.WriteLine($"Минимум {b}");
            Console.WriteLine("Список всех элементов массива:");
            Console.WriteLine(string.Join(" ", massiv));
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] % 2 != 0)
                {
                    Console.WriteLine($"Число явлется нечетным : {massiv[i]}");
                }
            }
            double average = sum / massiv.Length;
            Console.WriteLine($"Вычисление среднего арифметического элеметов массива : {average}");
        }
    }
}
