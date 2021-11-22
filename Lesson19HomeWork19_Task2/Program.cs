using System;
//Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>.
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов
namespace Lesson19HomeWork19_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count elements");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            MyList<int> myList = new MyList<int>(count,array);
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                myList[i] = random.Next(0, 100);
                myList.AddMethod(myList[i]);
            }
            Console.WriteLine($"All count elements in custom List<T>: {myList.AllCountElements}");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input index of Array: {index}");
            Console.WriteLine(myList[index]);
        }
    }
}
