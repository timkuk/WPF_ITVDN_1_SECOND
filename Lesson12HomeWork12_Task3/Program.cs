using System;
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship. 
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки. 
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Lesson12HomeWork12_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(1200, 232, DateTime.UtcNow, "Belarus");
            Vehicle plane = new Plane(vehicle.Price, vehicle.Speed, vehicle.YearMaking, 180, 250,vehicle.CordinatsVihicle);
            Vehicle ship = new Ship(vehicle.Price, vehicle.Speed, vehicle.YearMaking, 280, "Glazgo", vehicle.CordinatsVihicle);
            Vehicle car = new Саг(vehicle.Price, vehicle.Speed, vehicle.YearMaking, 4, "B", vehicle.CordinatsVihicle);
            plane.OutputInformationAboutVehicle();
            ship.OutputInformationAboutVehicle();
            car.OutputInformationAboutVehicle();
        }
    }
}
