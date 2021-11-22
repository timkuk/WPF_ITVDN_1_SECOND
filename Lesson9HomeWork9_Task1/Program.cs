using System;
//Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном порядке.
namespace Lesson9HomeWork9_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[10];
            for (int i = massiv.Length; i > 0; i--)
            { 
                Console.WriteLine(i);
            }
        }
    }
}
