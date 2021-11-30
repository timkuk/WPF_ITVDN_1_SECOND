using System;
using System.Collections.Generic;
//Создайте расширяющий метод:
//public static T[] GetArray<T>(this IEnumerable<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray()
namespace Lesson23HomeWork23_Task4
{
    public static class GetArray
    {
        public static T[] GetArrayOne<T>(this IEnumerable<T>[] list)
        {
            T[] myArray = new T[list.Length];
            return myArray;
        }
    }
}
