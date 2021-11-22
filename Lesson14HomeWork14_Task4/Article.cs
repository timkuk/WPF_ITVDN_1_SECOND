using System;
//Создать класс Article, содержащий следующие закрытые поля:
//• название товара;
//• название магазина, в котором продается товар;
//• стоимость товара в гривнах.
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности:
//• вывод информации о товаре по номеру с помощью индекса;
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,выдать соответствующее сообщение;
//Написать программу, вывода на экран информацию о товаре.
namespace Lesson14HomeWork14_Task4
{
    public class Article
    {
        private string nameGoods;
        private string nameShop;
        private double priceInDollar;
        public string NameGoods
        {
            get
            {
                return nameGoods;
            }
            set
            {
                nameGoods = value;
            }
        }
        public string NameShop
        {
            get
            {
                return nameShop;
            }
            set
            {
                nameShop = value;
            }
        }
        public double PriceInDollar
        {
            get
            {
                return priceInDollar;
            }
            set
            {
                if (value>0)
                {
                    priceInDollar = value;
                }
                else
                {
                    IndexOutOfRangeException ex = new IndexOutOfRangeException();
                    Console.WriteLine(ex.Message);
                }
            }
        }
        /// <summary>
        /// Реализация пользовательского конструктора
        /// </summary>
        /// <param name="nameGoods"></param>
        /// <param name="nameShop"></param>
        /// <param name="priceInDollar"></param>
        public Article(string nameGoods,string nameShop, double priceInDollar)
        {
            NameGoods =  nameGoods;
            NameShop = nameShop;
            PriceInDollar = priceInDollar;
        }
        /// <summary>
        /// Переопредлеление метода ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name goods {NameGoods} name shop {NameShop} price goods {PriceInDollar}";
        }
    }
}
