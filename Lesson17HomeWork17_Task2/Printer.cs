using System;
//Создайте статический класс с методом void Print (string stroka, int color), который выводит наэкран строку заданным цветом.
//Используя перечисление, создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю.
namespace Lesson17HomeWork17_Task2
{
    public static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta; 
                    Console.WriteLine(stroka);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine(stroka);
                    break;
                default:
                    Console.WriteLine("Invalid color!");
                    break;
            }
        }
    }
}
