using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
//Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого класса в формате XML
//Сначала используйте формат по умолчанию, а затем измените его таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML
namespace Lesson35HomeWork35_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Legasy));
            Legasy legasy = new Legasy();
            var forXml = legasy.FieldOfDream = "Dream";
            FileStream stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            serializer.Serialize(stream, legasy);
            stream.Close();
            //Сохранение значения поля в виде атрибута в XML документ
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Serialization.xml");
            XmlElement elmGarage = xmlDoc.CreateElement($"{legasy.FieldOfDream}");
            elmGarage.SetAttribute("id", $"{legasy.FieldOfDream}");
            xmlDoc.DocumentElement.AppendChild(elmGarage);
            xmlDoc.Save("Serialization.xml");
            //Десериализация и вывод инофрмации на консоль
            FileStream stream1 = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            legasy = serializer.Deserialize(stream1) as Legasy;
            Console.WriteLine(legasy);
        }
    }
}
