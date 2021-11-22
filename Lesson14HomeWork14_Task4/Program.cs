using System;
//Создать класс Article, содержащий следующие закрытые поля:
//• название товара;
//• название магазина, в котором продается товар;
//• стоимость товара в гривнах.
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности:
//• вывод информации о товаре по номеру с помощью индекса;
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,выдать соответствующее сообщение;
namespace Lesson14HomeWork14_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Article article0 = new Article("Xiaomi Mi Notebook Pro", "XI Store", 820);
            Article article1 = new Article("Asus Zen Book", "Asus Shop Seatle", 1200);
            Article article2 = new Article("MackBook Pro 2021 M1 MAX", "Apple Stpre", 4200);
            int countPositions = 3;
            Store store = new Store(countPositions);
            Console.WriteLine((store[0] = article0).ToString());
            Console.WriteLine((store[1] = article1).ToString());
            Console.WriteLine((store[2] = article2).ToString());
            string nameGoods = Console.ReadLine();
            Console.WriteLine($"Input name good please: {nameGoods}");
            if(nameGoods == "Xiaomi Mi Notebook Pro")
            {
                Console.WriteLine((store[0] = article1).ToString());
            }
            else
            {
                InvalidOperationException ex = new InvalidOperationException();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
