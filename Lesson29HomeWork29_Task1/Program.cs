using System;
using System.Collections;
//Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар 
//«ключ-значение» сначала в алфавитном порядке, а затем в обратном
namespace Lesson29HomeWork29_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList(new MyCamparer());
            sortedList["Monkey"] = 3;
            sortedList["Hipopotam"] = 4;
            sortedList["Animal"] = 1;

            foreach (DictionaryEntry oneElement in sortedList)
            {
                Console.WriteLine($"{oneElement.Key} - {oneElement.Value}");
            }
        }
    }
}
