using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Требуется описать структуру с именем Price, содержащую следующие поля: 
//• название товара; 
//• название магазина, в котором продается товар; 
//• стоимость товара в гривнах. 
//Написать программу, выполняющую следующие действия: 
//• ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны 
//быть упорядочены в алфавитном порядке по названиям магазинов); 
//• вывод на экран информации о товарах, продающихся в магазине, название которого введено с 
//клавиатуры (если такого магазина нет, вывести исключение).
namespace Lesson24HomeWork24_Task3
{
    /// <summary>
    /// Realization class Program
    /// </summary>
    public class Program
    {
        static int countWorkers = 2;
        public static Price[] priceArray = new Price[countWorkers];
        static void Main(string[] args)
        {
            try
            {
                for (int s = 0; s < countWorkers; s++)
                {
                    Console.WriteLine("Input name goods:");
                    priceArray[s].NameGoods = Console.ReadLine();
                    Console.WriteLine("Input name shop:");
                    priceArray[s].NameShop = Console.ReadLine();
                    Console.WriteLine("Input price in dollars:");
                    priceArray[s].PriceInDollars = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < countWorkers; k++)
                {
                    new Price(priceArray[k].NameGoods, priceArray[k].NameShop, priceArray[k].PriceInDollars);
                }

                Console.WriteLine("Input name shop for input information about goods on this shop :");
                string shopName = Console.ReadLine();
                int h = 0;
                while (h < countWorkers)
                {
                    if (priceArray[h].NameShop == shopName)
                    {
                        Console.WriteLine($"Good in this Shop -> {priceArray[h].NameGoods}");
                        break;
                    }
                    else if (countWorkers - 1 == h)
                    {
                        throw new Exception("NOT FOUNT SHOP ON THE DATA BASE!Input ones again!");
                    }
                    else
                    {
                        h++;
                    }
                }
            }
            //Realization block catch for handler exeption
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Method();
            }
            OutPutArray();
        }
        /// <summary>
        /// Realization Method who Outputing sorted information about shops on Console
        /// </summary>
        public static void OutPutArray()
        {
            Console.WriteLine("Sorted information about shops: ");
            Array.Sort(priceArray, new PriceCpmpare());
            for (int i = 0; i < countWorkers; i++)
            {
                Console.WriteLine($"Information about  {priceArray[i].NameShop} SHOP -> NameGoods :{priceArray[i].NameGoods}  -> Price In Dollars: {priceArray[i].PriceInDollars} ");
            }
        }
        /// <summary>
        /// Realization dublicate method deal if user input unvaliable name shop console don't close,and program working further
        /// </summary>
        public static void Method()
        {
            Console.WriteLine("Input name shop for input information about goods on this shop :");
            string shopName = Console.ReadLine();
            int h = 0;
            while (h < countWorkers)
            {
                if (priceArray[h].NameShop == shopName)
                {
                    Console.WriteLine($"Good in this Shop -> {priceArray[h].NameGoods}");
                    break;
                }
                else if (countWorkers - 1 == h)
                {
                    throw new Exception("NOT FOUNT SHOP ON THE DATA BASE!Input ones again!");
                }
                else
                {
                    h++;
                }
            }
        }
    }
}