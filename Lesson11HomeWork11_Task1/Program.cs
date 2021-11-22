using System;
//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты)
//Поле дата заполнения анкеты должно быть проинициализировано только один раз 
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
namespace Lesson11HomeWork11_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User("fedorenko_tim@mail.ru", "Tim", "Kurchenok", DateTime.Now);
            Console.WriteLine($" login: {user.login}\n name: {user.name}\n sername: {user.sername}\n time making anceta: {user.dateAnceta}");
        }
    }
}
