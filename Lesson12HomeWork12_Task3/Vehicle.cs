using System;
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship. 
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки. 
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Lesson12HomeWork12_Task3
{
    public class Vehicle
    {
        public string CordinatsVihicle { get; set; }
        public double Price { get; set; }
        public int Speed { get; set; }
        public DateTime YearMaking { get; set; }

        public Vehicle(double price, int speed, DateTime yearMaking, string cordinatsVihicle)
        {
            Price = price;
            Speed = speed;
            YearMaking = yearMaking;
            CordinatsVihicle = cordinatsVihicle;
        }
        virtual public void OutputInformationAboutVehicle()
        {
            Console.WriteLine("Information about this transport:");
        }

    }
}
