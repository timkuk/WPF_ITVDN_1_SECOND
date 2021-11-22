using System;
//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты)
//Поле дата заполнения анкеты должно быть проинициализировано только один раз при создании экземпляра данного класса)
// без возможности его дальнейшего изменения Реализуйте вывод на экран информации о пользователе
namespace Lesson11HomeWork11_Task1
{
    public class User
    {
        public string login;
        public string name;
        public string sername;
        public DateTime dateAnceta { get; private set;}

        /// <summary>
        /// Realization Defoult Constructor 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="name"></param>
        /// <param name="sername"></param>
        /// <param name="dateAnceta"></param>
        public User(string login, string name, string sername, DateTime dateAnceta)
        {
            this.login = login;
            this.name = name;
            this.sername = sername;
            this.dateAnceta = dateAnceta;
        }
    }
}
