using System;
//Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
//коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции используйте оператор yield
namespace Lesson28HomeWork28_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCollection user = new MyCollection();
            int[] intArray = new int[] { 1, 2, 3, 4, 100, 120, 113 };
            Console.WriteLine("Sorted collection:");
            foreach (var item in user.MethodCollectonGenerator(intArray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
