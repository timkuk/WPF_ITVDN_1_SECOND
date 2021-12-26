using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите консольное приложение, позволяющие пользователю зарегистрироваться под 
//«Логином», состоящем только из символов латинского алфавита, и пароля, состоящего из цифр и символов
namespace Lesson31HomeWork31_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Autorization autorization = new Autorization();
            Console.WriteLine("Введите логин на английском языке");
            string login = Console.ReadLine();
            Console.WriteLine("введите пароль состоящий из букв и символов");
            string password = Console.ReadLine();
            autorization.RegexMethod(login, password);
        }
    }
}
