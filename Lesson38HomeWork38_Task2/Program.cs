using System;
using System.IO;
using System.Threading;
//Приложение в различных потоках сможет получить доступ к 2-м файлам
//Считайте из этих файлов содержимое и попытайтесь записать полученную информацию в третий файл
//Чтение/запись должны осуществляться одновременно в каждом из дочерних потоков 
//Используйте блокировку потоков для того, чтобы добиться корректной записи в конечный файл
namespace Lesson38HomeWork38_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi1 = new FileInfo(@"E:\testThread1.txt");
            FileInfo fi2 = new FileInfo(@"E:\testThread2.txt");
            if (fi1.Exists)
            {
                using (StreamWriter sw = fi1.CreateText())
                {
                    sw.WriteLine("Thread1");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            else
            {
                fi1.Create();
            }
            if (fi2.Exists)
            {
                using (StreamWriter sw = fi2.CreateText())
                {
                    sw.WriteLine("Thread2");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            else
            {
                fi2.Create();
            }
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            using (StreamReader sr = fi2.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            FileAndThreads fileAndThreads = new FileAndThreads();
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 2; i++)
            {
                (threads[i] = new Thread(fileAndThreads.AccessToFileThreads)).Start(i+1);
            }
        }
    }
}
