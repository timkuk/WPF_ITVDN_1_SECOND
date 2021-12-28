using System;
using System.Xml;
//Создайте приложение, которое выводит на экран всю информацию об указанном .xml файле
namespace Lesson32HomeWork32_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson32HomeWork32_Task1\book.xml");
            Console.WriteLine(document.InnerText);
            Console.WriteLine(document.InnerXml);
        }
    }
}
