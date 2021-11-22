using System;
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока. 
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().
namespace Lesson19HomeWork19_Task4
{
    public static class Extentional
    {
        public static T[] GetArray<T>(this MyList<T> mylist, int count)
        {
            T[] newGenerickArray = new T[count]; 
            for(int i = 0; i < count; i++)
            {
                newGenerickArray[i] = mylist[i];
            }
            return newGenerickArray;
        }
    }
}
