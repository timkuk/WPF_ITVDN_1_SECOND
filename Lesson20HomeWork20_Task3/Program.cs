using System;
//Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
//использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен 
//System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
//должен включать метод добавления пар элементов, индексатор для получения значения элемента по 
//указанному индексу и свойство только для чтения для получения общего количества пар элементов.
namespace Lesson20HomeWork20_Task3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количесвто элементов для словаря");
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
