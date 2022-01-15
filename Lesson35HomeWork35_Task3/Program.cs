using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Lesson35HomeWork35_Task2;
//Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего примера. Отобразите состояние объекта на экране
namespace Lesson35HomeWork35_Task3
{
    public class  Program
    {
        static void Main(string[] args)
        {
            //Десериализация и вывод инофрмации на консоль
            XmlSerializer serializer = new XmlSerializer(typeof(Legasy));
            FileStream stream1 = new FileStream(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson35HomeWork35_Task2\bin\Debug\Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Legasy legasy = serializer.Deserialize(stream1) as Legasy;
            Console.WriteLine(legasy);
        }
    }
}
