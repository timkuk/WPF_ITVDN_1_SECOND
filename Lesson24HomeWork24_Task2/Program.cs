using System;
//• фамилия и инициалы работника; • название занимаемой должности;• год поступления на работу. 
//Написать программу, выполняющую следующие действия: 
//• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту); 
//• если значение года введено не в соответствующем формате выдает исключение;
//• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.
namespace Lesson24HomeWork24_Task2
{
    /// <summary>
    /// Realization class Program
    /// </summary>
    public class Program 
    {
        static int countWorkers = 5;
        public static Worker[] workers = new Worker[countWorkers];
        static void Main(string[] args)
        {
            try
            {
                for (int s = 0; s < countWorkers; s++)
                {
                    Console.WriteLine("Input Sername worker:");
                    workers[s].Sername = Console.ReadLine();
                    Console.WriteLine("Input Inithials worker:");
                    workers[s].Inithials = Console.ReadLine();
                    Console.WriteLine("Input name position worker:");
                    workers[s].WorkPositionName = Console.ReadLine();
                }
                int p = 0;
                while (p < countWorkers)
                {
                    Console.WriteLine("Input year when worker jet a job position worker:");
                    workers[p].YearWhenStartWorking = int.Parse(Console.ReadLine());
                    if (workers[p].YearWhenStartWorking < 2021 && workers[p].YearWhenStartWorking > 1940)
                    {
                        p++;
                    }
                    else
                    {
                        throw new Exception("Invalid Year Information!Input year from interval ->1940-2021<-");
                    }
                }
                Console.WriteLine("Input year woker which higher then input value");
                int yearInput = int.Parse(Console.ReadLine());
                for (int k = 0; k < countWorkers; k++)
                {
                    new Worker(workers[k].Sername, workers[k].Inithials, workers[k].WorkPositionName, workers[k].YearWhenStartWorking);
                }

                int h = 0;
                while (h < countWorkers)
                {
                    if (workers[h].YearWhenStartWorking > yearInput)
                    {
                        Console.WriteLine(workers[h].Sername);
                        break;
                    }
                    else if (countWorkers == h)
                    {
                        throw new Exception("NOT FOUNT HIGHER YEAR WHEN WORKER START!");
                    }
                    else
                    {
                        h++;
                    }
                }
            }
            //Realization block catch for handler exeption
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            OutPutArray();
        }
        /// <summary>
        /// Realization Method who Outputing sorted information about workers on Console
        /// </summary>
        public static void OutPutArray()
        {
            Console.WriteLine("List sorted workers: ");
            Array.Sort(workers, new StudentComparer());
            for(int i= 0; i < countWorkers; i++)
            {
                Console.WriteLine($"Sername worker :{workers[i].Sername} Initials: {workers[i].Inithials} WorkPositionName: {workers[i].WorkPositionName} YearWhenStartWorking: {workers[i].YearWhenStartWorking}");
            }
        }
    }
}
