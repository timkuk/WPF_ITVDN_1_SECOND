using System;
using System.Xml;
//Создайте.xml файл, который соответствовал бы следующим требованиям: 
//имя файла: TelephoneBook.xml
//корневой элемент: “MyContacts” 
//тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber” со значением номера телефона.
namespace Lesson32HomeWork32_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.WriteStartDocument();                  
            xmlWriter.WriteStartElement("MyContacts");      
            xmlWriter.WriteStartElement("Contact");          
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("+375299951428");          
            xmlWriter.WriteEndAttribute();                   
            xmlWriter.WriteString("Радионович Бородач");     
            xmlWriter.WriteEndElement();                     
            xmlWriter.WriteEndElement();                     
            xmlWriter.Close();
            var document = new XmlDocument();
            document.Load(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson32HomeWork32_Task1\bin\Debug\TelephoneBook.xml");
            Console.WriteLine(document.InnerText);
            Console.WriteLine(document.InnerXml);

        }
    }
}
