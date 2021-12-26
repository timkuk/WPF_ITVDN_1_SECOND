using System;
using System.Globalization;
//Создайте текстовый файл-чек по типу «Наименование товара – 0.00 (цена) грн.» сопределенным количеством наименований товаров и датой совершения покупки.
//Выведите на экран информацию из чека в формате текущей локали пользователя и в формате локали en-US
namespace Lesson31HomeWork31_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Текущая локаль: {0}.", currentCulture);
        }
    }
}
