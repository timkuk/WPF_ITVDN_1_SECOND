using System;
using System.Reflection;
//Создай атрибут уровня доступа пользователя к системе
//При помощи атрибута AccessLevelAttribute распределите уровни доступа персонала и отобразите
//на экране реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию
namespace Lesson34HomeWork34_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Staff tim = new Director("Director", "Tim");
            Staff tom = new Manager("Manager", "Tom");
            Staff kristi = new Programmer("Programmer", "Kristi");
            Search search = new Search();
            Console.WriteLine(search.ValidateUser(tim));
            Console.WriteLine(search.ValidateUser(tom));
            Console.WriteLine(search.ValidateUser(kristi));
        }
    }
}
