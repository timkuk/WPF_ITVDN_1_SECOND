using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24HomeWork24_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализируем переменные, содержащие строки вывода
            string topLeftText = "Top left corner";
            string topRightText = "Top right corner";
            string centerText = "Center";
            string bottomLeftText = "Bottom left corner";
            string bottomRightText = "Bottom right corner";

            //Очищаем консоль
            Console.Clear();

            //По умолчанию курсор находится в левом верхнем углу [0, 0], поэтому для вывода первой строки менять положение курсора не требуется
            Console.Write(topLeftText);

            //Рассчитываем положение для строки в верхнем левом углу
            int topRightX = Console.WindowWidth - topRightText.Length;
            //Указываем новые координаты курсора
            Console.SetCursorPosition(topRightX, 0);
            //Выводим текст
            Console.Write(topRightText);

            //Повторяем действия для левого нижнего угла
            int bottomY = Console.WindowHeight - 1;
            Console.SetCursorPosition(0, bottomY);
            Console.Write(bottomLeftText);

            //Для правого нижнего угла
            int bottomRightX = Console.WindowWidth - bottomRightText.Length;
            Console.SetCursorPosition(bottomRightX, bottomY);
            Console.Write(bottomRightText);

            // Выводим строку в центре экрана
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centerText);

            //Ждём нажатия клавиши перед выходом
            Console.ReadKey();
        }
    }
}
