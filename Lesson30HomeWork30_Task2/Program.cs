using System;
using System.IO;
//Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте 
//этот файл, прочитайте из него данные и выведете их на консоль.
namespace Lesson30HomeWork30_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"E:\Test.txt");
            StreamWriter writer = file.CreateText();
            writer.Write("Hello it is me");
            writer.Close();
            Console.WriteLine("File is closed");
            StreamReader reader = File.OpenText(@"E:\Test.txt");
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
