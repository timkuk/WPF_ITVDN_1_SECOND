using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Требуется описать структуру с именем Worker, содержащую следующие поля: 
//• фамилия и инициалы работника; 
//• название занимаемой должности; 
//• год поступления на работу. 
//Написать программу, выполняющую следующие действия: 
//• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту); 
//• если значение года введено не в соответствующем формате выдает исключение;
//• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.
namespace Lesson24HomeWork24_Task2
{
    public struct Worker
    {
        public string Sername { get; set; }
        public string Inithials { get; set; }
        public string WorkPositionName { get; set; }
        public int YearWhenStartWorking { get; set; }
        public Worker(string sername, string inithials, string workPositionName, int yearWhenStartWorking)
        {
            Sername = sername;
            Inithials = inithials;
            WorkPositionName = workPositionName;
            YearWhenStartWorking = yearWhenStartWorking;
        }
    }
}
