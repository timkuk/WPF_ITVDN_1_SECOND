//1)Создать метод который принимает в качестве аргумента массив целочисленных элементов и возвращает элементы массива в обратном порядке 
////2)Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index,размерностью,которая соответствует значению аргумента count.
//Если аргумент count содержит значение больше чем количество элементов, которые входят в выбираемую часть исходного
//массива (от указанного индекса index, до индекса последнего элемента),то при формировании нового массива
//размерностью в count, заполните единицами те элементы,которые не были скопированы из исходного массива.
using System;
namespace Lesson9HomeWork9_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] k = program.MyReverse(array);
            Console.WriteLine("Массив в обратном порядке:");
            program.CopiringMassiv(k);
            Console.WriteLine("\nВведите индекс массива c которого нужно вывести массив:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов массива которые нужно вывести:");
            int count = int.Parse(Console.ReadLine());
            int[] good = program.SubArray(array, index, count);
            Console.WriteLine("Результат выполнения метода SubArray:");
            program.CopiringMassiv(good);
        }
        /// <summary>
        /// Method Reversing
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] MyReverse(int[] array)
        {
            int[] reversArray = new int[array.Length];
            int k = array.Length;
            int j = 0;
            while (k > 0)
            {
                int buf = array[k - 1];
                
                while (j < array.Length)
                {
                    reversArray[j] = buf;
                    j++;
                    break;
                }
                k --;
            }
            return reversArray;
        }
        public void CopiringMassiv(int[] allArray)
        {
            for(int p = 0; p < allArray.Length; p++)
            {
                Console.Write($"\t {allArray[p]}");
            }
        }
        /// <summary>
        /// Method out put part of array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int[] SubArray(int[] array, int index, int count)
        {
            int[] myArray = new int[count];
            int key = index;
            int[] newArray = new int[array.Length];
            if (count >= array.Length)
            {
                myArray = new int[(count - array.Length)+array.Length];
                array.CopyTo(newArray, 0);
                int ArrayIndex = 0;
                while (index < newArray.Length)
                {
                    myArray[ArrayIndex] = array[index];
                    index++;
                    ArrayIndex++;
                }
                int i = 0;
                while (i < count-newArray.Length+key)
                {
                        myArray[ArrayIndex + i] = 1;
                        array = myArray;
                    i++;
                }
            }
            else if (count < array.Length)
            {
                int ArrayIndex=0;
                while (index < newArray.Length)
                {
                    myArray[ArrayIndex] = array[index];
                    index++;
                    ArrayIndex++;
                }
            }
            return myArray;
        }
    }
}
