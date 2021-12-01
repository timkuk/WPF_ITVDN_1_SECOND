using System;
using MyNamespace;
using Lesson23HomeWork23_Task3;
//Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте возможность 
//подключения вашего пространства имен и работы с MyDictionary<TKey, TValue> аналогично 
//экземпляру класса Dictionary<TKey, TValue>.
namespace Lesson27HomeWork27_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetHashCode());
            Console.WriteLine("Введите количество элементов для словаря");
            int length = int.Parse(Console.ReadLine());
            Dictionary<string, string> dictionary = new Dictionary<string, string>(length);
            //Метод добавления пар элементов
            for (int k = 0; k < length; k++)
            {
                string[] keys = { "книга", "ручка", "солнце", "яблоко" };
                string[] value = { "book", "pen", "sun", "apple" };
                if (length <= keys.Length)
                {
                    Console.WriteLine(dictionary.Add(keys[k], value[k]));
                }
                else
                {
                    Console.WriteLine("Ошибка!Количесво элементов в словаре меньше чем в массиве!");
                }
                Console.WriteLine(new string('-', 20));
                //Индексатор для получения значения по указаннному индексу
                Console.WriteLine(dictionary[0]);
                Console.WriteLine(dictionary[1]);
                Console.WriteLine(dictionary[2]);
                Console.WriteLine(dictionary[3]);
                Console.WriteLine(dictionary[4]);
                Console.WriteLine(dictionary[5]);
                Console.WriteLine("Общее количесвто пар элементов");
                Console.WriteLine(dictionary.Count);
            }
        }
    }
}
