using System;
//В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
//В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
//"Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
//Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
//"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных 
//форматах доступно в версии Эксперт".
//Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
//Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
//"Документ сохранен в новом формате".
//В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается 
//экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен 
//создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
namespace Lesson12HomeWork12_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Menu;
            do
            {
                Console.WriteLine("\n\tMenu");
                Console.WriteLine("1.Base Verion");
                Console.WriteLine("2.Expert Version");
                Console.WriteLine("3.Pro Version");
                Console.WriteLine("4.Exit\n");
                Menu = Console.ReadLine();
                if (Menu == "1")
                {
                    DocumentWorker baseVersion = new DocumentWorker();
                    baseVersion.OpenDocument();
                    baseVersion.EditDocument();
                    baseVersion.SaveDocument();
                }
                else if (Menu == "2")
                {
                    DocumentWorker expert = new ExpertDocumentWorker();
                    ExpertDocumentWorker expertDocumentWorker = (ExpertDocumentWorker)new ExpertDocumentWorker();
                    expertDocumentWorker.OpenDocument();
                    expertDocumentWorker.EditDocument();
                    expertDocumentWorker.SaveDocument();
                }
                else if (Menu == "3")
                {
                    DocumentWorker professional = new ProDocumentWorker();
                    ProDocumentWorker proDocument = (ProDocumentWorker)new ProDocumentWorker();
                    proDocument.OpenDocument();
                    proDocument.EditDocument();
                    proDocument.SaveDocument();
                }
            } while (Menu != "4");
        }
    }
}
