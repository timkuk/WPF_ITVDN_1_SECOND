using System;
//Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
//Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.
namespace Lesson14HomeWork14_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations(3);
            Console.Write("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[N];
            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
                sum = sum + massiv[i];
            }
            MathOperations myOperations = new MathOperations(massiv);
            mathOperations.OutPutMassiv(massiv);
            mathOperations.MaxElementOfArray(massiv);
            mathOperations.MinElementOfArray(massiv);
            mathOperations.SearchOddNumber(massiv);
            mathOperations.SumElementArray(massiv);
            mathOperations.ArithmeticMean(massiv);
        }
    }
}
