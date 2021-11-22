using System;
//Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность 
//использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
//взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года 
//ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство только для 
//чтения для получения общего количества элементов.
//Создайте метод удаления всех машин автопарка.
namespace Lesson20HomeWork20_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесвто элементов для словаря");
            int length = int.Parse(Console.ReadLine());
            CarCollection<int> car = new CarCollection<int>(length);
            Console.WriteLine(car.Add(0, "BMW",DateTime.Now));
            Console.WriteLine(car.Add(1, "Toyota", DateTime.Now));
            Console.WriteLine(car.Add(2, "Honda", DateTime.Now));
            car.Remove();
        }
    }
}
