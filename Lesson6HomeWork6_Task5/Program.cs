using System;
//Реализуйте приложение, которое соответствует следующим требованиям:
//• при запуске запрашивает у пользователя ввод высоты и ширины прямоугольника, а также -
//символа для отрисовки прямоугольника
//• после успешного ввода данных, выводит, с помощью указанного пользователем символа,
//прямоугольник заданных пользователем размеров в левом верхнем углу консоли
//• позволяет пользователю перемещать прямоугольник по экрану с помощью клавиш W/A/S/D и 
//символов стрелок
//• при нажатии клавиши Escape, выводит сообщение о завершении работы
//Для реализации управления прямоугольником используйте цикл "Паук". 
namespace Lesson6HomeWork6_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину  прямоугольника:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ для отрисовки прмоугольника:");
            string symbol = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    Console.Write(symbol);
                }
                Console.Write("\n");
            }
            ConsoleKey keyPressed = Console.ReadKey(true).Key;
            for (; ; )
            {
                switch (keyPressed)
                {
                    case ConsoleKey.W: // 'W' - охраняющее условие 1.
                        {
                            for (int i = 0; i < hight; i++)
                            {
                                for (int j = 0; j < weight; j++)
                                {
                                    Console.Write(symbol);
                                }
                                Console.Write("\n");
                                Console.ReadKey();
                                Console.Clear();
                            }
                                continue;
                        }
                        case ConsoleKey.A: // 'A' - охраняющее условие 2.
                        {
                            for (int i = 0; i < hight; i++)
                            {
                                for (int j = 0; j < weight; j++)
                                {
                                    Console.Write(symbol);
                                }
                                Console.Write("\n");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            continue;
                         }
                         case ConsoleKey.D: // 'D' - охраняющее условие 3.
                             {
                                Console.Write("\n\t\t\t\t");
                                for (int i = 0; i < hight; i++)
                                {
                                    for (int j = 0; j < weight; j++)
                                    {
                                        Console.Write(symbol);
                                    }
                                    Console.Write("\n\t\t\t\t");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                             }
                         case ConsoleKey.S: // 'S' - охраняющее условие 4.
                            {
                                Console.WriteLine("\n\n\n\n");
                                for (int i = 0; i < hight; i++)
                                {
                                    for (int j = 0; j < weight; j++)
                                    {
                                        Console.Write(symbol);
                                    }
                                    Console.Write("\n");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                               
                            }

                         case ConsoleKey.LeftArrow: // 'W' - охраняющее условие 1.
                             {
                                 for (int i = 0; i < hight; i++)
                                 {
                                     for (int j = 0; j < weight; j++)
                                     {
                                         Console.Write(symbol);
                                     }
                                     Console.Write("\n");
                                     Console.ReadKey();
                                     Console.Clear();
                                 }
                                 continue;
                              }
            
                         case ConsoleKey.RightArrow: // 'A' - охраняющее условие 2.
                             {
                                Console.Write("\n\t\t\t\t");
                                for (int i = 0; i < hight; i++)
                                {
                                    for (int j = 0; j < weight; j++)
                                    {
                                        Console.Write(symbol);
                                    }
                                 Console.Write("\n\t\t\t\t");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                             }
                         case ConsoleKey.DownArrow: // 'D' - охраняющее условие 3.
                             {
                            Console.WriteLine("\n\n\n\n");
                            for (int i = 0; i < hight; i++)
                            {
                                for (int j = 0; j < weight; j++)
                                {
                                    Console.Write(symbol);
                                }
                                Console.Write("\n");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                         case ConsoleKey.UpArrow: // 'S' - охраняющее условие 4.
                             {
                                for (int i = 0; i < hight; i++)
                                {
                                    for (int j = 0; j < weight; j++)
                                    {
                                        Console.Write(symbol);
                                    }
                                    Console.Write("\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                continue;
                            }
                }
                switch (keyPressed)
                {
                    case ConsoleKey.Escape: // 'Escape' - условие выхода 1.
                        {
                            Console.WriteLine("Завершение работы"); break; // команда завершения.
                        }
                }
                break;  // Прерывание цикла.
            }
        }
    }
}


