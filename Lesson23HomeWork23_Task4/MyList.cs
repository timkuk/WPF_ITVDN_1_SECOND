using System;
using System.Collections.Generic;

namespace Lesson23HomeWork23_Task4
{
    public class MyList<T>
    {
        public Element<T>[] elementsArray = null;
        public MyList(int length)
        {
            elementsArray = new Element<T>[length];
        }
        int count = 0;
        public int Count { get => count; }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < elementsArray.Length)
                    return $"{elementsArray[index]}";
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public Element<T>[] Add(int length, int[] array)
        {
            for (int k = 0; k < length; k++)
            {
                elementsArray[k] = AddInCollection(array[k], length);
                count++;
            }
            return elementsArray;
        }
        public Element<T> AddInCollection(int argumentArray,int length)
        {
            Element<T> elementsArray = new Element<T>(argumentArray,length);
            return elementsArray;
        }
    }
}

