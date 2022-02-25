using System;
using System.Collections;
using System.Collections.Generic;
//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции
//Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей
namespace Lesson29HomeWork29_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Products> productsList = new() { new Products("Banana", 12, "Made in Gvinea"), new Products("Oranges", 8, "Made in Malasya"), new Products("Bread", 2, "Made in Belarus") };
            List<Products> productsList1 = new() { new Products("Potato", 12, "Made in Gvinea"), new Products("Appels", 8, "Made in Poland"), new Products("Swits", 2, "Made in Swithland") };
            List<Customers> customers = new() { new Customers("Tim", 19, productsList), new Customers("Artem", 22, productsList1) };
            for(int i=0;i<customers.Count;i++)
            {
                Console.WriteLine($"Name Customer -{customers[i].Name} Age Customer-{customers[i].Age}  Products Customer:");
                for(int j = 0; j < productsList.Count;j++)
                {
                    Console.WriteLine(@$"{ customers[i].productsList[j].NameProduct}
                                         { customers[i].productsList[j].Quantity}
                                         { customers[i].productsList[j].WhenMade}");
                }
            }
            Console.WriteLine(new string('-', 100));
            for (int j = 0; j < productsList.Count; j++)
            {
                 for (int k = 0; k < customers.Count; k++)
                 {
                    if(customers[k].productsList[j].NameProduct == "Banana")
                    {
                        Console.WriteLine($"Name person who buy exclusive cotegory product -> {customers[k].Name}");
                    }
                 }
            }
        }
    }
}
