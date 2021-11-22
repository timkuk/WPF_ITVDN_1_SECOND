using System;

namespace  Lesson7HomeWork7_Task3
{
    public class Bancomat
    {
        public string Adress { get; set; }
        public string FullName { get; set; }

        public static double RoubelsAvalieble { get; set; }
        //public double Money { get; set; }
        //Метод реализующий выдачу наличных


        public Bancomat(string Adress, string FullName, double roubelsAvalieble)
        {
            this.Adress = Adress;
            this.FullName = FullName;
            RoubelsAvalieble = roubelsAvalieble;
        }

        public void Inputmoney(double roubelsAvalieble)
        {
            double roubels = roubelsAvalieble;
            Console.WriteLine($"Выдано {roubels} BYN.Хотите продолжить операцию?Вас обслуживал сотрудник {FullName} по адресу {Adress}");

        }
        //Метод реалзующий зачисление денег на счет
        public void Transfer(double Money)
        {
            Console.WriteLine($"На счет положено {Money} денег");
        }
        public void ConverterMoney(double Money)
        {
            double convertDollor = Money / 2.6;
            double convertEuro = Money / 3.1;
            Console.WriteLine($"Вы получили {convertDollor} Долларов или {convertEuro} Евро");
            Console.ReadKey();
        }
    }
}

