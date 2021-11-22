using System;
//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.
//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
namespace Lesson14HomeWork14_Task3
{
    public class MyMatrix
    {
        int[,] matrix ;
        private int i,j;
        public int I
        {
            get
            {
                return i;
            }
        }
        public int J
        {
            get
            {
                return j;
            }
        }
        public MyMatrix(int[,] matrix)
        {
            this.matrix =new int[i,j];
            for(int k = 0; k < i; k++)
            {
                matrix[i, j] = 0;
            }
        }
        public int this[int i,int j]
        {
            get
            {
                return this.matrix[i, j];
            }
            set
            {
                this.matrix[i, j] = value;
            }
        }
        public void WorkingWithAmtrix(int[,] matrix)
        {
            for (int p = 0; p < matrix.GetLongLength(0); p++)
            {
                for (int k = 0; k < matrix.GetLongLength(1); k++)
                {
                    Random random = new Random();
                    int rand = random.Next(0, 100);
                    matrix[i, j] = rand;
                }
            }
        }
        public void OutPutMatrix(int[,] matrix)
        {
            for (int p = 0; p < matrix.GetLongLength(0); p++)
            {
                for (int k = 0; k < matrix.GetLongLength(1); k++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(matrix[0, 0]);
        }
    }
}
