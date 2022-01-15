using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//Создайте пользовательский тип  и выполните сериализацию объекта этого типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети
namespace Lesson35HomeWork35_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassForSearized classForSearized = new ClassForSearized("Life is Good");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = File.Create("firstserialization.dat");
            formatter.Serialize(fileStream, classForSearized);
            fileStream.Close();
            fileStream = File.OpenRead("firstserialization.dat");
            classForSearized = formatter.Deserialize(fileStream) as ClassForSearized;
            Console.WriteLine($"Information {classForSearized.LifeField}");
        }
    }
}
