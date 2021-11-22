using System;
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки. 
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Lesson12HomeWork12_Task3
{
    public class Plane : Vehicle
    {
        public double HightPasagir { get; set; }
        public int NumberPassagirs { get; set; }
        public Plane(double price, int speed, DateTime yearMaking, double hightPasagir, int numberPassagirs, string cordinatsVihicle) : base( price,  speed,  yearMaking,  cordinatsVihicle)
        {
            HightPasagir = hightPasagir;
            NumberPassagirs = numberPassagirs;
        }
        public override void OutputInformationAboutVehicle()
        {
            base.OutputInformationAboutVehicle();
            Console.WriteLine($"This is Plane she has more addditional settings including {base.Price}, {base.Speed}, {base.YearMaking}");
        }
    }
}
