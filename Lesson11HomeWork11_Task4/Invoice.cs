using System;
//В теле класса создать три поля int account, string customer, string provider, которые должны быть 
//проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
namespace Lesson11HomeWork11_Task4
{
    public class Invoice
    {
        public int account { get; private set; }
        public string customer { get; private set; }
        public string provider { get; private set; }
        private string article;
        private int quantity;
        const double NDSinBelarus = 20;
        public Invoice(int account,string customer, string provider, string article, int quantity)
        {
            this.account  =  account;
            this.customer =  customer;
            this.provider =  provider;
            this.article  =  article;
            this.quantity =  quantity;
        }
        public void CostWithTax(int productPrice)
        {
            double totalPrice = quantity * productPrice;
            double priceWithNDC = totalPrice  + (totalPrice * (NDSinBelarus / 100));
            Console.WriteLine($"Your vaucher: account {account} customer {customer} provider {provider} article {article} quantity {quantity} \nTotal price with NDS {priceWithNDC}$");
        }
        public void CostWithOutTax(int productPrice)
        {
            double totalPrice = quantity * productPrice;
            Console.WriteLine($"Your vaucher: account {account} customer {customer} provider {provider} article {article} quantity {quantity} \nTotal price without NDS: {totalPrice}$");
        }
    }
}
