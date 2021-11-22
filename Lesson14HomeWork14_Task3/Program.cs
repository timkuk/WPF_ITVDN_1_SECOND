using System;
//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.
//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
namespace Lesson14HomeWork14_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value matrix: ");
            int stroka = Convert.ToInt32(Console.ReadLine());
            int stolbets = Convert.ToInt32(Console.ReadLine());
            int[,] matx = new int[stroka, stolbets];
            MyMatrix myMatrix = new MyMatrix(matx);
            myMatrix.WorkingWithAmtrix(matx);
            myMatrix.OutPutMatrix(matx);
        }
    }
}
