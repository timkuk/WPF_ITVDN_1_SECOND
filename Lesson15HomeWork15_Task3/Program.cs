using System;
//Cоздать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
namespace Lesson15HomeWork15_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] A = new int[] { 10, 2, 3 };
            Program.Sort(A);
        }
        /// <summary>
        /// Realization Method
        /// </summary>
        /// <param name="A"></param>
        public static void Sort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }
            //Realization Extention Method
            A.Print();
        }
    } 
}        

