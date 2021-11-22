using System;
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship. 
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки. 
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Lesson12HomeWork12_Task3
{
    public class Саг : Vehicle
    {
        public int CountRings { get; set; }
        public string Category { get; set; }
        public Саг(double price, int speed, DateTime yearMaking, int countRings, string category, string cordinatsVihicle) : base(price, speed, yearMaking, cordinatsVihicle)
        {
            Category = category;
            CountRings = countRings;        
        }
        public override void OutputInformationAboutVehicle()
        {
            base.OutputInformationAboutVehicle();
            Console.WriteLine($"This is Car she has more addditional settings including {base.Price}, {base.Speed}, {base.YearMaking}  Category Auto {Category} CountRings {CountRings} ");
        }
    }
}
