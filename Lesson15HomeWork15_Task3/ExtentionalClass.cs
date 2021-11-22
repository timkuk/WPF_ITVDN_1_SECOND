using System;

namespace Lesson15HomeWork15_Task3
{
    public static class ExtentionalClass
    {
        /// <summary>
        /// Realization Extention Method
        /// </summary>
        /// <param name="B"></param>
        public static void Print(this int[] A)
        {
           for(int j = 0; j < A.Length; j++)
            {
                Console.WriteLine(A[j]);
            }
        }
    }
}
