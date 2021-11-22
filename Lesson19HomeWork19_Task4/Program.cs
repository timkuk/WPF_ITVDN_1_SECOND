using System;
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока. 
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().
namespace Lesson19HomeWork19_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count elements");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            MyList<int> myList = new MyList<int>(count, array);
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                myList[i] = random.Next(0, 100);
                myList.AddMethod(myList[i]);
            }
            Console.WriteLine("Value elements with using Method  GetArray()");
            for(int k = 0; k < count; k++)
            {
                int[] newArray = myList.GetArray<int>(count);
                Console.WriteLine(newArray[k].ToString());
            }
        }
    }
}
