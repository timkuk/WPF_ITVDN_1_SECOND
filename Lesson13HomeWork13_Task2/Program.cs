using System;
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны 
//быть методы открытия, создания, редактирования, сохранения определенного формата документа.
namespace Lesson13HomeWork13_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Menu;
            do
            {
                Console.WriteLine("Input format File including : DOC TXT XML");
                Menu = Console.ReadLine();
                if (Menu == "DOC")
                {
                    AbstractHandler doc = new DOCHandler();
                    doc.Open() ;
                    doc.Create();
                    doc.Chenge();
                    doc.Save();
                }
                else if (Menu == "TXT")
                {
                    AbstractHandler doc = new TXTHandler();
                    doc.Open();
                    doc.Create();
                    doc.Chenge();
                    doc.Save();
                }
                else if (Menu == "XML")
                {
                    AbstractHandler doc = new XMLHandler();
                    doc.Open();
                    doc.Create();
                    doc.Chenge();
                    doc.Save();
                }
            } while (Menu != "4");
        }
    }
}
