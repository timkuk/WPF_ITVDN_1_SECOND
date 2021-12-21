using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и 
//количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по 
//порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не только один месяц
namespace Lesson28HomeWork28_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = new MonthCollection();
            collection[0] = new Element("Январь", 30, 1);
            collection[1] = new Element("Февраль", 28, 2);
            collection[2] = new Element("Март", 30, 3);
            collection[3] = new Element("Апрель", 30, 4);
            collection[4] = new Element("Май", 31, 5);
            collection[5] = new Element("Июнь", 30, 6);
            collection[6] = new Element("Июль", 30, 7);
            collection[7] = new Element("Август", 31, 8);
            collection[8] = new Element("Сентябрь", 30, 9);
            collection[9] = new Element("Октябрь", 30, 10);
            collection[10] = new Element("Ноябрь", 30, 11);
            collection[11] = new Element("Декабрь", 30, 12);

            foreach (Element element in collection)
            {
                Console.WriteLine("{0}, {1}, {2}", element.NameMonth, element.CountDays , element.SerialNumber.ToString());
            }
            Console.WriteLine("Выберите номер месяц");
            int inputMonth = int.Parse(Console.ReadLine());
            foreach (Element element in collection)
            {
                if (element.SerialNumber == inputMonth)
                {
                    Console.WriteLine("{0}, {1}, {2}", element.NameMonth, element.CountDays , element.SerialNumber.ToString());
                }
            }
            Console.WriteLine("Введите количество дней в искомом месяце");
            int inputCountDays = int.Parse(Console.ReadLine());
            foreach (Element element in collection)
            {
                if (element.CountDays == inputCountDays)
                {
                    Console.WriteLine("{0}, {1}, {2}", element.NameMonth, element.CountDays , element.SerialNumber.ToString());
                }
            }
        }
    }
}
