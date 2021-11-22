using System;
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship. 
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки. 
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Lesson12HomeWork12_Task3
{
    public class Ship : Vehicle
    {
        public int CountPassagirs { get; set; }
        public string PortLiving { get; set; }
        public Ship(double price, int speed, DateTime yearMaking,int countPassagirs, string portLiving, string cordinatsVihicle) : base(price, speed, yearMaking, cordinatsVihicle)
        {
            CountPassagirs = countPassagirs;
            PortLiving = portLiving;
        }
        public override void OutputInformationAboutVehicle()
        {
            base.OutputInformationAboutVehicle();
            Console.WriteLine($"This is Ship she has more addditional settings including {base.Price}, {base.Speed}, {base.YearMaking} CountPassagirs: {CountPassagirs} PortLiving :{PortLiving}");
        }
    }
}
