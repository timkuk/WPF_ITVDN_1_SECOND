using System;
//Создайте класс, который будет содержать информацию о дате (день, месяц, год)
//С помощью механизма перегрузки операторов, определите операцию разности двух дат 
//результат в виде количества дней между датами,а также операцию увеличения даты на определенное количество дней
namespace Lesson25HomeWork25_Task4
{
    /// <summary>
    /// Realization class witch consist iformation about date
    /// </summary>
    public class Information
    {
        private int day;
        private int mounth;
        private int year;
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value > 0 || value < 31)
                {
                    mounth = value;
                }
                else
                {
                    Console.WriteLine("День должен быть в диапазоне от 1 до 31");
                }
            }
        }
        public int Mounth
        {
            get
            {
                return mounth;
            }
            set
            {
                if (value > 0 || value<12)
                {
                    mounth=value;
                }
                else
                {
                    Console.WriteLine("Месяц должен быть в диапазоне от 1 до 12");
                }
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Information(int day, int mounth, int year)
        {
            this.day = day;
            this.mounth = mounth;
            this.year = year;
        }
        /// <summary>
        /// Realization Method Reloding operator -
        /// </summary>
        /// <param name="second"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static Information operator -(Information second, Information first)
        {
            int convertMounthToDays = 0;
            int countMonth = 0;
            int countDaysAfterCalculate = 0;
            if (second.day == 31 && second.day == 1 && first.day == 1 && first.day == 31)
            {
                if (first.mounth > second.mounth)
                {
                    int normalMounth = 12 - first.mounth;
                    countMonth = second.mounth + normalMounth;
                    convertMounthToDays = countMonth * 30;
                }
                else
                {
                    countMonth = second.mounth - first.mounth;
                    convertMounthToDays = countMonth * 30;
                }
            }
            else
            {
                if (first.mounth > second.mounth)
                {
                    int normalMounth = 12 - first.mounth;
                    countMonth = (30 - second.mounth) + (normalMounth * 30);
                    convertMounthToDays = countMonth;
                }
                else
                {
                    countMonth = second.mounth - first.mounth;
                    convertMounthToDays = countMonth * 30;
                }
            }
            int countYears = Math.Abs(second.year - first.year);
            if (countYears == 1)
            {
                countDaysAfterCalculate = convertMounthToDays;
            }
            else
            {
                int convertYearsToDays = countYears * 30 * 12;
                countDaysAfterCalculate = convertYearsToDays + convertMounthToDays;
            }
            return new Information(Math.Abs((second.day - first.day) + countDaysAfterCalculate), Math.Abs(second.mounth - first.mounth), Math.Abs(second.year - first.year));
        }
        /// <summary>
        /// Realization Method Reloding operators +
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Information operator +(Information first, Information second)
        {
            int k = 0;
            return new Information(second.day - k,first.day,first.year);
        }
        /// <summary>
        /// Realization method ToString output to console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{this.day}");
        }
    }
}
