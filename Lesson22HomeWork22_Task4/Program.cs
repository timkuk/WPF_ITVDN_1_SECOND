using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson22HomeWork22_Task4
{
    class Program
    {
        static object block = new object();
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            void ClearColumn(int x)
            {
                for (int y = 0; y < height; y++)
                {
                    lock (block) // блокировка консоли
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                }
            }

            void PrintLine(object x)
            {
                while (true)
                {
                    int lenght = random.Next(3, 10); // длинна столбца
                    int speed = random.Next(300, 900); // значение задержки слип
                    for (int pos = 0; pos < height; pos++)
                    {
                        for (int s = 0; s < lenght; s++)
                        {
                            if (pos - s == -1)
                                break;
                            lock (block) // блокировка консоли
                            {
                                Console.SetCursorPosition((int)x, pos - s);
                                switch (s)
                                {
                                    case 0:
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        break;
                                }
                                Console.Write((char)random.Next(65, 91));
                            }
                        }
                        Thread.Sleep(speed);
                        ClearColumn((int)x);
                    }
                }
            }
            ParameterizedThreadStart writeSnake = new ParameterizedThreadStart(PrintLine);
            int n = 0;

            while (true)
            {
                new Thread(writeSnake).Start(n);
                n += random.Next(1, 4);
                if (n >= width - 1)
                    break;
            }
        }
    }
}