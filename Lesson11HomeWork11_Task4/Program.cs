using System;
//В теле класса создать три поля int account, string customer, string provider, которые должны быть 
//проинициализированы один раз (при создании экземпляра данного класса) без возможности их 
//дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
namespace Lesson11HomeWork11_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(114224, "Tim", "Apple", "Iphone 12", 2);
            invoice.CostWithTax(1200);
            invoice.CostWithOutTax(1200);
        }
    }
}
