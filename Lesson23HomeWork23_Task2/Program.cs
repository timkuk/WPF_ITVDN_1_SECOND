using System;
using System.Collections;
//Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования 
//ее экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс 
//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для 
//получения значения элемента по указанному индексу и свойство только для чтения для получения 
//общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле foreach
namespace Lesson23HomeWork23_Task2
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
        }
    }
}
