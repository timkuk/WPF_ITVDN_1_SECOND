using System;
//Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.
namespace Lesson17HomeWork17_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input birthday date ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            CalculateNextBirthday(birthday);
        }
        public static void CalculateNextBirthday(DateTime birthday)
        {
            int howMonthToEndYear = 12 - DateTime.Now.Month;
            int howManyMonthBeginingBithday = 12 - (12 -birthday.Month);
            int countMonthForNextBirtday = Math.Abs((12-DateTime.Now.Month) + howManyMonthBeginingBithday);
            int countDaysForNextBirtday = countMonthForNextBirtday * 30;
            Console.WriteLine($"Count days from the next Birthday {countDaysForNextBirtday}");
        }
    }
}
