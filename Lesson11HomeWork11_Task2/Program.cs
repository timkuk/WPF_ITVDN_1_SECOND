using System;
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и 
//инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также 
//программа должна производить конвертацию из указанных валют в гривну
namespace Lesson11HomeWork11_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(120, 2300, 25000);
            Console.WriteLine(converter.GrivnaToMoney(5000));
            Console.WriteLine(converter.MoneyToGrivna(converter.usd, converter.eur, converter.rub));
        }
    }
}
