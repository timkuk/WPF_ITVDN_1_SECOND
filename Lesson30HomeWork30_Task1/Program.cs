using System;
using System.IO;
//Создайте на диске 100 директорий с именами от Folder_0 до Folder_99, затем удалите их.
namespace Lesson30HomeWork30_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"E:\ITVDN");
            if (directory.Exists)
            {
                for(int i = 0; i < 100; i++)
                {
                    var subDirectory = directory.CreateSubdirectory($@"Folder_{i}");
                    Console.WriteLine("Под Директория с именем: {0}  создана", subDirectory.FullName);
                }
                Console.WriteLine("Под Директории созданы");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
                Directory.CreateDirectory(@"D:\TESTDIR");
            }
        }
    }
}
