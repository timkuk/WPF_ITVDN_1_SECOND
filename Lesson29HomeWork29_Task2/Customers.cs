using System;
using System.Collections;
using System.Collections.Generic;
//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции
//Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей
namespace Lesson29HomeWork29_Task2
{
    public class Customers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Products> productsList = null;
        public Customers(string Name, int Age, List<Products> productsList)
        {
            this.Name = Name;
            this.Age = Age;
            this.productsList = productsList;
        }
    }
}
