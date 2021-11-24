using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Требуется описать структуру с именем Price, содержащую следующие поля: 
//• название товара; 
//• название магазина, в котором продается товар; 
//• стоимость товара в гривнах. 
//Написать программу, выполняющую следующие действия: 
//• ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны быть упорядочены в алфавитном порядке по названиям магазинов); 
//• вывод на экран информации о товарах, продающихся в магазине, название которого введено с клавиатуры
//(если такого магазина нет, вывести исключение).
namespace Lesson24HomeWork24_Task3
{
    public struct Price
    {
        public string NameGoods { get; set; }
        public string NameShop { get; set; }
        public int PriceInDollars { get; set; }
        public Price(string nameGoods, string nameShop, int priceInDollars)
        {
            NameGoods = nameGoods;
            NameShop = nameShop;
            PriceInDollars = priceInDollars;
        }
    }
}
