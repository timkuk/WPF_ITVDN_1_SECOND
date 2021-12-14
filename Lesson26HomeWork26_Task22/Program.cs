using System;
using System.Collections.Generic;
using System.Linq;
//Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую 
//коллекцию автомобилей со следующими данными: марка автомобиля, модель, год выпуска, цвет. А 
//также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона. 
//Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из 
//автомобилей и полную характеристику приобретенной им модели
namespace Lesson26HomeWork26_Task22
{
    public class CarStation
    {
        public string Model { get; set; }
        public string Mark { get; set; }
        public int YearProduction { get; set; }
        public string Color { get; set; }

    }
    public class ClientInfo
    {
        public string Model { get; set; }
        public string NameBuyer { get; set; }
        public string PhoneNumber { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var carCollectionOne = new List<CarStation>
            {
                new CarStation(){Model = "Picnic", Mark = "Toyota", YearProduction = 1998, Color = "Pink"},
                new CarStation(){Model = "Civic", Mark = "Honda", YearProduction = 2008, Color = "Black"},
                new CarStation(){Model = "Accord", Mark = "Honda", YearProduction = 2016, Color = "Black"},
                new CarStation(){Model = "CRV", Mark = "Honda", YearProduction = 2006, Color = "Grey"}
            };

            var carCollectionTwo = new List<ClientInfo>
            {
                new ClientInfo(){Model = "Picnic", NameBuyer = "Tim Kuk", PhoneNumber = "+3752767677"},
                new ClientInfo(){Model = "Civic", NameBuyer = "Alex Flud", PhoneNumber = "+3752767677"},
                new ClientInfo(){Model = "Accord", NameBuyer = "Tim Kur", PhoneNumber = "+3752767677"},
                new ClientInfo(){Model = "CRV", NameBuyer = "Kon Kurochka", PhoneNumber = "+3752767677"},
            };

            var query = from emp in carCollectionOne
                        join n in carCollectionTwo
                        on emp.Model equals n.Model
                        orderby n.NameBuyer descending
                        select new
                        {
                            Model = emp.Model,
                            Mark = emp.Mark,
                            YearProduction = emp.YearProduction,
                            Color = emp.Color,
                            NameBuyer = n.NameBuyer,
                            PhoneNumber = n.PhoneNumber
                        };

            foreach (var person in query)
            {
                Console.WriteLine($"Name buyer {person.NameBuyer} Mack car {person.Mark} Model car {person.Model} Year when produce {person.YearProduction} Color {person.Color} Phone number {person.PhoneNumber}");
                break;
            }
        }

    }
}

