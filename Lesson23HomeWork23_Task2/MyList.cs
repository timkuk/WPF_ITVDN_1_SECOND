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
        public Element[] elementsArray = null;
        public MyList(int length)
        {
            elementsArray = new Element[length];
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
        public Element[] Add(int length,int[] array)
        {
            for (int k = 0; k < length; k++)
            {
                elementsArray[k] = AddInCollection(array[k]);
                count++;
            }
            return elementsArray;
        }
        public Element AddInCollection(int argumentArray)
        {
            Element elementsArray = new Element(argumentArray);
            return elementsArray;
        }
    }
}
