using System;
//Требуется: Cоздать общий абстрактный класс для всех частей документа.
namespace Lesson13HomeWork13_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document title1 = new Title();
            title1.Show();
            Document body1 = new Body();
            body1.Show();
            Document footer1 = new Footer();
            footer1.Show();
            Console.ReadKey();
        }
    }
}
