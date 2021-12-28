using System;
using System.Xml;
//Из файла TelephoneBook.xml (файл должен был быть создан в процессе выполнения дополнительного задания) выведите на экран только номера телефонов
namespace Lesson32HomeWork32_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reader = new XmlTextReader(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson32HomeWork32_Task1\bin\Debug\TelephoneBook.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("Contact")) 
                    {
                        Console.WriteLine("{0}", reader.GetAttribute("TelephoneNumber"));
                    }
                }
            }
        }
    }
}
