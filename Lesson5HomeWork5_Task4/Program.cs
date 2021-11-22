using System;
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
//Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно 
//выслуге лет. 
//Если выслуга до 5 лет, премия составляет 10% от заработной платы. 
//Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы. 
//Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы. 
//Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы. 
//Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы. 
//Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы. 
//Результаты расчета, выведите на экран.
namespace Lesson5HomeWork5_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year selary worker");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter workExperience ");
            double workExperience = Convert.ToDouble(Console.ReadLine());
            if (workExperience <= 5)
            {
                Console.WriteLine($"Salary with premia {salary = salary*0.1} $");
            }
                else if(workExperience >= 5 && workExperience<=10)
                {
                    Console.WriteLine($"Salary with premia {salary = salary * 0.15} $");
                }
                    else if (workExperience >= 10 && workExperience <= 15)
                    {
                         Console.WriteLine($"Salary with premia {salary = salary * 0.25} $");
                    }
                        else if (workExperience >= 15 && workExperience <= 20)
                        {
                             Console.WriteLine($"Salary with premia {salary = salary * 0.35} $");
                         }
                            else if (workExperience >= 20 && workExperience <= 25)
                            {
                                  Console.WriteLine($"Salary with premia {salary = salary * 0.45} $");
                            }
                                else if (workExperience >= 25 && workExperience <= 100)
                                {
                                    Console.WriteLine($"Salary with premia {salary = salary * 0.5} $");
                                }
        }
    }
}
