using System;
using System.Text.RegularExpressions;
//Напишите консольное приложение, позволяющие пользователю зарегистрироваться под 
//«Логином», состоящем только из символов латинского алфавита, и пароля, состоящего из цифр и символов
namespace Lesson31HomeWork31_Task1
{
    public class Autorization
    {
        const string patternLogin = @"^[A-Za-z]";
        const string pattarnPassword = @"^[А-Яа-яA-Za-z0-9]";
        public void RegexMethod(string login,string password)
        {
            var loginRegex = new Regex(patternLogin);
            var passwordRegex = new Regex(pattarnPassword);
            Console.WriteLine(
                    loginRegex.IsMatch(login)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", login, patternLogin);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                    passwordRegex.IsMatch(login)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", password, pattarnPassword);
        }
    }
}
