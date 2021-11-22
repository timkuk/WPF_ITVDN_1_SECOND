using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой цепочки задается случайно
//Первый символ цепочки – белый, второй символ – светло-зеленый,остальные символы темно-зеленые 
//Во время падения цепочки, на каждом шаге, все символы меняют свое значение
//Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка
namespace Lesson22HomeWork22_Task2
{
    public class Program
    {
        //public static char[] GenerateRandomChaine(int lengthChain)
        //{
        //    Random random = new Random();
        //    char[] a = new char[lengthChain];
        //    for (int j = 0; j < lengthChain - 1; j++)
        //    {
        //        if (a[j] == a[0])
        //        {
        //            Console.ForegroundColor = ConsoleColor.White;
        //            a[j] = (char)random.Next(0x021, 0x07E);
        //        }
        //        else if (a[j] == a[1])
        //        {
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            a[j] = (char)random.Next(0x021, 0x07E);
        //        }
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.DarkGreen;
        //            a[j] = (char)random.Next(0x021, 0x07E);
        //        }
        //        return a;
        //}
        static void Matrix()
        {
            //int count = 1150;
            int x = 0;
            int y = 0;
            Random random = new Random();
            int lengthChain = random.Next(3, 15);
            do
            {
                char[] a = new char[lengthChain];
                for (int j = 0; j < lengthChain - 1; j++)
                {
                    //if (x < 0)
                    // x = 0;
                    //else if (x >= Console.BufferWidth)
                    //    x = Console.BufferWidth - 1;
                    if (y < 0)
                        y = 0;
                    else if (y >= Console.BufferHeight)
                        y = Console.BufferHeight - 1;
                    y++;
                    if (a[j] == a[0])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        a[j] = (char)random.Next(0x021, 0x07E);
                    }
                    else if (a[j] == a[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        a[j] = (char)random.Next(0x021, 0x07E);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        a[j] = (char)random.Next(0x021, 0x07E);
                    }
                    Console.Write($"\n {a[j]} ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.Clear();
                int k = 0;
                if (k==1)
                {
                    Console.SetCursorPosition(0, 0);
                }
                else
                {
                    Console.SetCursorPosition(x, y); 
                }
                k++;
            }
            while (true);
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Matrix));
            thread.Start();
        }
    }
}
