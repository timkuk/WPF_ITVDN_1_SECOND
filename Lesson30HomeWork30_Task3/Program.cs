using System.IO;
using System;
using System.Text;
//Напишите приложение для поиска заданного файла на диске
//Добавьте код, использующий класс FileStream и позволяющий просматривать файл в текстовом окне
//В заключение добавьте возможность сжатия найденного файла
namespace Lesson30HomeWork30_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Имеющиеся диски:");

            foreach (string drive in drives)
                Console.WriteLine("- {0}", drive);
            Console.WriteLine("Select disk ");
            //ReadAllText();
        }
        //public static string ReadAllText(string filePath)
        //{
        //    using (FileStream stream = File.OpenRead(filePath))
        //    {
        //        var encoding = new UTF8Encoding(true);
        //        var reader = new StreamReader(stream, encoding);
        //        return reader.ReadToEnd();
        //    }
        //}
    }
}
