using System;
using System.Collections;
//Создайте коллекцию MyList<T>
//Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List<T>
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для 
//получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов
//Реализуйте возможность перебора элементов коллекции в цикле foreach
namespace Lesson23HomeWork23_Task2
{
    public class MyList<T>
    {
        public int[] myList;
        int count = 0;
        public int Count { get => count; }
        public MyList(int length)
        {
            myList = new int[length];
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < myList.Length)
                    return $"{myList[index]}";
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public int[] ResultAdditing(int length, int[] array)
        {
            int[] newArray = new int[length-1];
            for (int k = 0; k < length-1; k++)
            {
                newArray[k] = AddInCollection(array[k]);
            }
            return newArray;
        }
        public int AddInCollection(int argumentArray)
        {
            if (count < myList.Length)
            {
                myList[count] = argumentArray;
                count++;
                return myList[count];
            }
            return myList[count];
        }
    }
}
