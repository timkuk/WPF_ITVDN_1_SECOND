using System;
//Напишите программу, которая будет выполнять конвертирование валют. 
//Пользователь вводит: 
//сумму денег в определенной валюте. 
//курс для конвертации в другую валюту. 
//Организуйте вывод результата операции конвертирования валюты на экран.
namespace Lesson7HomeWork7_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Адрес Банкомата");
            string adress = Console.ReadLine();
            Console.WriteLine("Количество наличности на банкомате");
            double roubels = Console.Read();
            Console.WriteLine("Введите имя сотрудника");
            string nameSotudnik = Console.ReadLine();
            //double money = Console.Read();
            Bancomat userTim = new Bancomat(adress, nameSotudnik, roubels);
            userTim.Inputmoney(123);
            userTim.Transfer(123);
            userTim.ConverterMoney(123);
        }
    }
}
