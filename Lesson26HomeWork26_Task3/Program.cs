using System;
using System.Collections.Generic;
using System.Linq;
//Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание
namespace Lesson26HomeWork26_Task3
{
    public class Program
    {
        static IDictionary<TKey, TValue> NewDictionary<TKey, TValue>(TKey key, TValue value)
        {
            return new Dictionary<TKey, TValue>();
        }
        static IDictionary<TKey, TValue> NewDictionary1<TKey, TValue>(dynamic key, dynamic value)
        {
            return new Dictionary<TKey, TValue>();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                var dict = NewDictionary(new { ID = 1 }, new { Column = "Dollar", Localized = "Доллар" });
                Console.WriteLine(NewDictionary(new { ID = 1 }, new { Column = "Dollar", Localized = "Доллар" }).ToString());
            }
            for (int i = 0; i < 9; i++)
            {
                dynamic first = "Apple";
                dynamic second = "Яблоко";
                Console.WriteLine(NewDictionary1<dynamic, dynamic>(first, second).ToString());
            }
        }
        public override string ToString()
        {
            return $"Англо Русский словарь";
        }
    }
}
