using System;
using System.Collections;
//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции
//Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей
namespace Lesson29HomeWork29_Task2
{
    public class Products 
    {
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public string WhenMade { get; set; }
        public Products(string NameProduct, int Quantity, string WhenMade) 
        {
            this.NameProduct = NameProduct;
            this.Quantity = Quantity;
            this.WhenMade = WhenMade;
        }
    }
}
