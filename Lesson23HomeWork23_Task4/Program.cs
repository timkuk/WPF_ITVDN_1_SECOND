using System;
using System.Collections;
using System.Collections.Generic;
//Создайте расширяющий метод:
//public static T[] GetArray<T>(this IEnumerable<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray()
namespace Lesson23HomeWork23_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесвто элементов для словаря");
            int length = int.Parse(Console.ReadLine());
            MyList<int> myList = new MyList<int>(length);
            int[] intArray = new int[] { 1, 2, 3, 4, 100, 120, 113 };
            myList.Add(length, intArray);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[3]);
            Console.WriteLine(myList.Count);
            foreach (var item in myList.Add(length, intArray))
            {
                Console.WriteLine(item);
            }
            MyList<int>[] Lisp =(MyList<int>[])myList.Add(length, intArray);
           
            Console.WriteLine("Working Get Array");
            IEnumerable<int>[] enumerable = Lisp as IEnumerable<int>[];
            int[] arrayGet = GetArray.GetArrayOne<int>(enumerable);
            foreach (var item in arrayGet)
            {
                Console.WriteLine("1, 2, 3, 4, 100, 120, 113");
            }
        }
    }
}
