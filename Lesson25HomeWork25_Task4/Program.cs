using System;
//Создайте класс, который будет содержать информацию о дате (день, месяц, год). С помощью 
//механизма перегрузки операторов, определите операцию разности двух дат (результат в виде 
//количества дней между датами), а также операцию увеличения даты на определенное количество дней
namespace Lesson25HomeWork25_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Information dateOne = new Information(29, 11, 2021);
            Information dateSecond = new Information(31, 01, 2021);
            //subtraction second date to first date
            Information resultDate = dateSecond - dateOne;
            Console.WriteLine(resultDate);
            //Incrising date on the count
            int resultMinus = dateOne.Day + 100;
            Console.WriteLine(resultMinus);
        }
    }
}
