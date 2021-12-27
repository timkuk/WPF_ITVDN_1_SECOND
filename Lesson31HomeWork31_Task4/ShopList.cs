using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
//Создайте текстовый файл-чек по типу «Наименование товара – 0.00 руб» с определенным количеством наименований товаров и датой совершения покупки
//Выведите на экран информацию из чека в формате текущей локали пользователя и в формате локали en-US
namespace Lesson31HomeWork31_Task4
{
    public class ShopList
    {
        private double price { get; set; }
        const string pattern = @"";
        public ShopList(double price)
        {
            this.price = price;
        }
        public double Rub
        {
            get { return price; }
        }

        public double Euro
        {
            get { return price / 3.1; }
        }

        public double Dollar
        {
            get { return price /2.5; }
        }
     
        public string ToString(string format, IFormatProvider provider)
        {
            StreamReader reader = File.OpenText(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task4\Чек.txt");
            string infoOnTheFile = reader.ReadToEnd();
            Console.WriteLine(reader.ReadToEnd());
            if (String.IsNullOrEmpty(format))
                format = "G";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "R":
                    string result = Regex.Replace(infoOnTheFile, @"\b(\w){1}\b", "₽");
                    return result;
                case "E":
                    result = Regex.Replace(infoOnTheFile, @"\b(\w){1}\b", "€");
                    return result;
                case "G":
                case "D":
                    result = Regex.Replace(infoOnTheFile, @"\b(\w){1}\b", "$");
                    return result;
                default:
                    throw new FormatException(
                        String.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
