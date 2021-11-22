using System;
//Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его 
//экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
namespace Lesson20HomeWork20_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесвто элементов для словаря");
            int length = int.Parse(Console.ReadLine());
            ArrayList arrayList = new ArrayList(length);
            arrayList.Add(12);
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
        }
    }
}
