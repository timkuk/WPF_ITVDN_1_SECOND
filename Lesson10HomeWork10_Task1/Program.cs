using System;
//Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого 
//поля, создать свойство с двумя методами доступа. 
//Создать экземпляр класса Address. 
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
namespace Lesson10HomeWork10_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.index = 246006;
            adress.country = "Belarus";
            adress.city = "Gomel";
            adress.street = "Kozhara";
            adress.house = 57;
            adress.apartment = 32;
            Console.WriteLine($"Человек проживает с индексом {adress.index} в стране {adress.country} в городе {adress.city} по адресу {adress.street} {adress.house} {adress.apartment}");

        }
    }
}
