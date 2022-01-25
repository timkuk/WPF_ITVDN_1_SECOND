using System;
using System.IO;
//Приложение в различных потоках сможет получить доступ к 2-м файлам
//Считайте из этих файлов содержимое и попытайтесь записать полученную информацию в третий файл
//Чтение/запись должны осуществляться одновременно в каждом из дочерних потоков 
//Используйте блокировку потоков для того, чтобы добиться корректной записи в конечный файл
namespace Lesson38HomeWork38_Task2
{
    public class FileAndThreads
    {
        static object block = new object();
        public void AccessToFileThreads(object barsi)
        {
            lock (block)
            {
                FileInfo fi3 = new FileInfo(@"E:\testThread3.txt");
                if (fi3.Exists)
                {
                    Console.WriteLine("File is open");
                    StreamReader reader = File.OpenText($@"E:\testThread{barsi}.txt");
                    var readInTheFile = reader.ReadToEnd();
                    Console.WriteLine($"Information into the file testThread{barsi}.txt \n{readInTheFile}");
                    Console.WriteLine("Write the testThread3.txt File");
                    StreamWriter writer = fi3.CreateText();
                    for (int i = 0; i < (int)barsi; i++)
                    {
                        writer.WriteLine($"\n\n"); 
                    }
                    writer.WriteLine($"{readInTheFile}");
                    writer.Close();
                }
                else
                {
                    fi3.Create();
                    Console.WriteLine("File is open");
                    StreamReader reader = File.OpenText($@"E:\testThread{barsi}.txt");
                    var readInTheFile = reader.ReadToEnd();
                    StreamWriter writer = fi3.CreateText();
                    writer.WriteLine(readInTheFile);
                    writer.Close();
                }
            }
        }        
    }
}
