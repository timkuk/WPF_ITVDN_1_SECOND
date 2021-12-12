using System.IO;
using System;
using System.Text;
using System.IO.Compression;
//Напишите приложение для поиска заданного файла на диске
//Добавьте код, использующий класс FileStream и позволяющий просматривать файл в текстовом окне
//В заключение добавьте возможность сжатия найденного файла
namespace Lesson30HomeWork30_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var searchFile = new FileInfo(@"E:\Test.txt");
            Console.WriteLine("Поиск заданного файла на диске");
            try
            {
                FileStream stream = searchFile.OpenRead();
                Console.WriteLine($"Заданный файл найден {searchFile}");
                FileStream source = File.Create(@"E:\Test.zip");
                Console.WriteLine("Архивирование исходного файла");
                GZipStream compressor = new GZipStream(source, CompressionMode.Compress);
                int TheByte = stream.ReadByte();
                while(TheByte != -1)
                {
                    compressor.WriteByte((byte)TheByte);
                    TheByte = stream.ReadByte();
                }
                Console.WriteLine("\nТекст из файлика в консольном окне:");
                StreamReader reader = File.OpenText(@"E:\Test.txt");
                string input;
                // Выводим содержимое файла в консоль.
                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                compressor.Close();
                reader.Close();
                stream.Close();
            }
            catch
            {
                Console.WriteLine("Такого файла не существует");
            }
        }
    }
}
