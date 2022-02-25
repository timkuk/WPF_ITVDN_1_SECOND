using System;
using System.Collections;
using System.Collections.Specialized;
//Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений ключей
namespace Lesson29HomeWork29_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionaryComparer edgv = new OrderedDictionaryComparer();
            OrderedDictionary orderedDictionary = new OrderedDictionary(edgv);
            orderedDictionary["Goodbye"] = "Пока";
            orderedDictionary["Imposible"] = "Невозможно";
            orderedDictionary["Creative"] = "Креативный";

            OrderedDictionary orderedDictionary2 = new OrderedDictionary();
            orderedDictionary2["Goodbye"] = "Покеда";
            
            foreach(DictionaryEntry dictionary in orderedDictionary)
            {
                foreach(DictionaryEntry dictionary1 in orderedDictionary2)
                {
                    Console.WriteLine(dictionary.Key.Equals(dictionary1.Key).ToString());
                }
            }
        }
    }
}
