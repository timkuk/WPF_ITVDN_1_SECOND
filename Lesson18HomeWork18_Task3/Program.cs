using System;
//Создайте анонимный метод который принимает в качестве аргумента массив делегатов
//Возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве
//Методы сообщенные с делегатами из массива возвращают случайное значение типа int
namespace Lesson18HomeWork18_Task3
{
    /// <summary>
    /// Realization DelegateWithArray
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public delegate int DelegateWithArray (DelegateWithParameters[] array);
    /// <summary>
    /// Realization DelegateWithParameters
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public delegate int DelegateWithParameters();
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count elements on massiv");
            int count = int.Parse(Console.ReadLine());
            Random random = new Random();
            DelegateWithParameters calculateDelegate = () => random.Next(-100,100);
            int sum = 0;
            DelegateWithParameters[] array = new DelegateWithParameters[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = new DelegateWithParameters(calculateDelegate);
                DelegateWithArray delegateMy = (DelegateWithParameters[] array) => array[i].Invoke();
                sum = sum+delegateMy.Invoke(array);
            }
            Console.WriteLine(sum / array.Length);
        }
    }
}
