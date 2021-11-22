using System;
//Создайте статический класс с методом void Print (string stroka, int color), который выводит на
//экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных пользователю.
//Ввод строки и выбор цвета предоставьте пользователю.
namespace Lesson17HomeWork17_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string messege = Console.ReadLine();
            Console.WriteLine("Input color 0 ->Yellow \n 1->Green \n 2->Blue \n 3->Magenta \n 4->Red  ");
            int color = int.Parse(Console.ReadLine());
            Printer.Print(messege, color); 
        }
    }
}
