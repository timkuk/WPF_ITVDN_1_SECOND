using System;
using System.Collections.Generic;
//Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и 
//вещественные значения, по типу «счет предприятия – доступная сумма» соответственно
namespace Lesson29HomeWork29_Task3
{
    public class Program
    {
        static void Main()
        {
            var dict = new Dictionary<int, double>();
            dict[3248] = 12.355;
            dict[4248] = 4454.23213;
            dict[1248] = 4454.23213;
            dict[2248] = 4454.23213;
            dict[2248] = 4454.23213;
            foreach (KeyValuePair<int, double> i in dict)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));
            SortedDictionary<int, double> keyValuePairs = new SortedDictionary<int, double>();
            keyValuePairs[3262] = 12.355;
            keyValuePairs[4262] = 4454.23213;
            keyValuePairs[1262] = 4454.23213;
            keyValuePairs[2262] = 4454.23213;
            keyValuePairs[2262] = 4454.23213;
            foreach (KeyValuePair<int, double> i in keyValuePairs)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }
            Console.ReadKey();
        }
    }
}
