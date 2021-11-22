using System;
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и 
//инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также 
//программа должна производить конвертацию из указанных валют в гривну
namespace Lesson11HomeWork11_Task2
{
    public class Converter
    {
        public double usd;
        public double eur;
        public double rub;
        public double grivna { get; set; }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double GrivnaToMoney(double grivna)
        {
            Console.WriteLine("Input name valuet: 1 - USD 2 - EUR 3 - RUB");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key == 1)
            {
                return grivna * 0.038;
            }
            else if (key == 2)
            {
                return grivna * 0.033;
            }
            else 
            {
                return grivna * 2.69;
            }
        }
        public double MoneyToGrivna(double usd, double eur, double rub)
        {
           Console.WriteLine("Input name operation: 1 - Convertetion USD to Grivna \n 2 - Convertetion EUR to Grivna 3 - Convertetion RUB to Grivna ");
            int key = Convert.ToInt32(Console.ReadLine());
            double grivna = 0;
            if (key == 1)
            {
                return  grivna = usd / 0.038;
            }
            else if (key == 2)
            {
                return grivna = eur / 0.033;
            }
            else
            {
                return grivna = rub / 2.69; ;
            }
        }
    }
}
