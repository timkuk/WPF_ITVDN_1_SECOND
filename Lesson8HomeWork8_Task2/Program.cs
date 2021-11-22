using System;
namespace Lesson8HomeWork8_Task2
//Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент 
//кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен 
//выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн. закрыть весь долг. 
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную 
//экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма задолженности,
//сумма переплаты, сообщение об отсутствии долга).
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер кредита :");//700
            double creditValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество платежей для погашения долга:");//2
            double howManyPayments = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму для погашения долга:");
            double payment = Convert.ToDouble(Console.ReadLine());//300+400
            Program program = new Program();
            program.CreditMethod(payment, creditValue, howManyPayments);
        }
        public void CreditMethod(double payment, double creditValue, double howManyPayments)
        {
            Console.WriteLine($"Кредит взят на имя Путин Владимир Владимирович сумма крдита : {creditValue} $ количество платежей которые должен сделать клиент {howManyPayments} \n платёж который поступил сегодня на счет банка составляет {payment} $");
            double accountBalance = creditValue - payment;
            if (accountBalance > 0)
            {
                Console.WriteLine($"Счет погашен на сумму {payment}$ остаток задолженности по кредиту : {accountBalance}$");
            }
            else if (accountBalance == 0)
            {
                Console.WriteLine($"Кредит полностью  погашен {payment}$ сумма задолженности {accountBalance}$");
            }
            else if (accountBalance < 0)
            {
                double overpayment = Math.Abs(accountBalance);
                Console.WriteLine($"Кредит полностью  погашен {creditValue} $ сумма переплаты по кредиту составляет {overpayment}$");
            }
        }
    }
}
