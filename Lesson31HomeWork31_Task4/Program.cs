using System;
using System.Globalization;
using System.Text;
//Создайте текстовый файл-чек по типу «Наименование товара – 0.00 руб» с определенным количеством наименований товаров и датой совершения покупки
//Выведите на экран информацию из чека в формате текущей локали пользователя и в формате локали en-US
namespace Lesson31HomeWork31_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Текущая локаль: {0}.", currentCulture);
            ShopList shop = new ShopList(12);
            Console.WriteLine(shop.ToString("D", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(shop.ToString("E", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(shop.ToString("R", CultureInfo.CreateSpecificCulture("ru-RU")));
        }
    }
}
