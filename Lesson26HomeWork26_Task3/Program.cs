using System;
using System.Collections.Generic;
using System.Linq;
//Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание
//Надо создать собственный класс словаря.Только тут надо использовать уже анонимные типы
//И динамические для доступа к переменным анонимных типов
namespace Lesson26HomeWork26_Task3
{
    public class Program
    {

        //static IDictionary<TKey, TValue> NewDictionary<TKey, TValue>(TKey key, TValue value)
        //{
        //    return new Dictionary<TKey, TValue>();
        //}
        //static IDictionary<TKey, TValue> NewDictionary1<TKey, TValue>(dynamic key, dynamic value)
        //{
        //    return new Dictionary<TKey, TValue>();
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов для словаря");
            int length = int.Parse(Console.ReadLine());
            Dictionary<string, string> dictionary = new Dictionary<string, string>(length);
            //Метод добавления пар элементов
            for (int k = 0; k < length; k++)
            {
                string[] keys  = { "книга", "ручка", "солнце", "яблоко", "рука" , "писатель","чемпион","тюрьма","оружие","простой" };
                string[] value = { "book", "pen", "sun", "apple", "hand" , "writer", "chempion", "prison", "gun" , "elementory"};
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
            //for (int i = 0; i < 9; i++)
            //{
            //    var dict = NewDictionary(new { ID = 1 }, new { Column = "Dollar", Localized = "Доллар" });
            //    Console.WriteLine(NewDictionary(new { ID = 1 }, new { Column = "Dollar", Localized = "Доллар" }).ToString());
            //}
            //for (int i = 0; i < 9; i++)
            //{
            //    dynamic first = "Apple";
            //    dynamic second = "Яблоко";
            //    Console.WriteLine(NewDictionary1<dynamic, dynamic>(first, second).ToString());
            //}
        }
        public override string ToString()
        {
            return $"Англо Русский словарь";
        }
    }
}
