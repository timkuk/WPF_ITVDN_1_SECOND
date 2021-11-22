using System;
//Создать метод, который будет выполнять увеличение длины массива на 1 элемент.Элементы массива, должны сохранить свое значение и порядок индексов. 
//Создайте метод, который принимает два аргумента, первый аргумент  int [] array, второй аргумент  int.
//В теле метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,при этом длина нового массива,
//должна увеличиться на 1 элемент, а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса 1.
namespace Lesson9HomeWork9_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВведите на сколько нужно увеличить массив:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите число для дополнения массива:");
            int number = int.Parse(Console.ReadLine());
            int[] result=program.ArrayOperations(array, index, number);
            program.CopiringMassiv(result);

        }
        /// <summary>
        /// Increasing the length of the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] ArrayOperations(int[] array, int index,int number)
        {
            int[] myArray = new int[array.Length + index];
            int ArrayIndex = 1;
            int count = 0;
            while (count < array.Length)
            {
                myArray[ArrayIndex] = array[count];
                count++;
                ArrayIndex++;
            }
            int i = 0;
            while (i < index)
            {
                myArray[0] = number;
                array = myArray;
                i++;
            }
            return myArray;
        }
        /// <summary>
        /// Output information in massiv
        /// </summary>
        /// <param name="allArray"></param>
        public void CopiringMassiv(int[] allArray)
        {
            for (int p = 0; p < allArray.Length; p++)
            {
                Console.Write($"\t {allArray[p]}");
            }
        }
    }
}
