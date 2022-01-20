using System;
using System.Threading;
//Создайте свой класс, объекты которого будут занимать много места в памяти (например, в коде класса будет присутствовать большой массив) 
//и реализуйте для этого класса,формализованный шаблон очистки
namespace Lesson36HomeWork36_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AllGarbage garbage = new AllGarbage();
            new Thread(garbage.InputOnArray).Start();
            Garbage @object = new Garbage();
            Console.WriteLine($"System max generation used {GC.MaxGeneration + 1} ");
            for(int i = 0; i < 40; i++)
            {
                Console.Write($"Generation Garbage object  {GC.GetGeneration(@object)} |");
                Console.WriteLine($"How many memory used  {GC.GetTotalMemory(true) / 1024}");
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Поколение 0 проверялось {0} раз", GC.CollectionCount(0));
            Console.WriteLine("Поколение 1 проверялось {0} раз", GC.CollectionCount(1));
            Console.WriteLine("Поколение 2 проверялось {0} раз", GC.CollectionCount(2));
            Console.WriteLine(new string('-', 40));
        }
    }
}
