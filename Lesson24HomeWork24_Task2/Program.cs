using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//• фамилия и инициалы работника; 
//• название занимаемой должности; 
//• год поступления на работу. 
//Написать программу, выполняющую следующие действия: 
//• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту); 
//• если значение года введено не в соответствующем формате выдает исключение;
//• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.
namespace Lesson24HomeWork24_Task2
{
    public class Program 
    {
        static int countWorkers = 5;
        public static Worker[] workers = new Worker[countWorkers];
        static void Main(string[] args)
        {
             try
             {
                 Console.WriteLine("Input information about worker");
                 Console.WriteLine("Input Sername worker:");
                 string sername = Console.ReadLine();
                 string sername1 = Console.ReadLine();
                 string sername2 = Console.ReadLine();
                 string sername3 = Console.ReadLine();
                 string sername4 = Console.ReadLine();
                 Console.WriteLine("Input Inithials worker:");
                 string inithials = Console.ReadLine();
                 string inithials1 = Console.ReadLine();
                 string inithials2 = Console.ReadLine();
                 string inithials3 = Console.ReadLine();
                 string inithials4 = Console.ReadLine();
                 Console.WriteLine("Input name position worker:");
                 string position = Console.ReadLine();
                 string position1 = Console.ReadLine();
                 string position2 = Console.ReadLine();
                 string position3 = Console.ReadLine();
                 string position4 = Console.ReadLine();
                 Console.WriteLine("Input year when worker jet a job position worker:");
                 int year = int.Parse(Console.ReadLine());
                 if (year > 2021 || year < 1960)
                 {
                     throw new Exception("Invalid Year Information!");
                 }
                 int year1 = int.Parse(Console.ReadLine());
                 int year2 = int.Parse(Console.ReadLine());
                 int year3 = int.Parse(Console.ReadLine());
                 int year4 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Input year woker which higher then input value");
                 int yearInput = int.Parse(Console.ReadLine());
                 Worker worker = new Worker(sername, inithials, position, year);
                 Worker worker1 = new Worker(sername1, inithials1, position1, year1);
                 Worker worker2 = new Worker(sername2, inithials2, position2, year2);
                 Worker worker3 = new Worker(sername3, inithials3, position3, year3);
                 Worker worker4 = new Worker(sername4, inithials4, position4, year4);
                 workers[0] = worker;
                 workers[1] = worker1;
                 workers[2] = worker2;
                 workers[3] = worker3;
                 workers[4] = worker4;
                 try
                 {
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
                 catch (Exception e)
                 {
                     Console.WriteLine(e.Message);
                 }
                 OutPutArray();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
        }
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
