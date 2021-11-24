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
//Расширьте задание 2, так, чтобы в одном столбце одновременно могло быть две цепочки символов
  namespace Lesson22HomeWork22_Task3
  {
      public class Program
      {
          /// <summary>
          /// Realization Class Thrading who communicate with Method GenerateRandomChaine()
          /// </summary>
          /// <param name="column"></param>
          public  void Matrix(object column)
          {
              int intColomn = (int)column;
              GenerateRandomChaine(intColomn);
          }
          /// <summary>
          /// Realization method ,he generate random chaine symbols on interaval,and changing console color 
          /// </summary>
          /// <param name="count"></param>
          public static void GenerateRandomChaine(int count)
          {
              Console.SetBufferSize(130, 50);
              Console.SetWindowSize(130, 50);
              int x = 0;
              int y = 0;
              Random random = new Random();
              int speed = random.Next(300, 900);
              int lengthChain = random.Next(3, 12);
              do
              {
                  char[] a = new char[lengthChain];
                  int tabs = Console.WindowWidth - (Console.WindowWidth - count); 
                  for (int j = 0; j < lengthChain - 1; j++)
                  {
                      if (x <= 0)
                      {
                          x = Console.WindowWidth - Console.WindowWidth + 120;
                      }
                      else if (x <= Console.BufferWidth)
                      {
                          x = 0;
                      }
                      if (y < 0)
                      {
                          y = 0;
                      }
                      else if (y == Console.BufferHeight)
                      {
                          y = 0;
                      }
                      else if (y >= Console.BufferHeight)
                      {
                          y = Console.BufferHeight - 1;
                      }
                      y++;
                      if (a[j] == a[0])
                      {
                          Console.ForegroundColor = ConsoleColor.White;
                          a[j] = (char)random.Next(0x041, 0x05A);
                      }
                      else if (a[j] == a[1])
                      {
                          Console.ForegroundColor = ConsoleColor.Cyan;
                          a[j] = (char)random.Next(0x041, 0x05A);
                      }
                      else
                      {
                          Console.ForegroundColor = ConsoleColor.DarkGreen;
                          a[j] = (char)random.Next(0x041, 0x05A);
                      }
                      string symbol = Convert.ToString(a[j]);
                      symbol = symbol.PadLeft(symbol.Length + tabs, '\0');
                      Thread.Sleep(speed);
                      Console.WriteLine($"\n {symbol}");
                      Thread.Sleep(speed);
                  }
                  Console.ForegroundColor = ConsoleColor.Gray;
                  Thread.Sleep(speed);
                  Console.Clear();

                if (y >= Console.BufferHeight)
                  {
                      int security = y / 50 + 1;
                      if (security % 2 == 0)
                      {
                          Console.CursorTop = 0;
                      }
                      else
                      {
                          Console.SetCursorPosition(x, y);
                      }
                  }
                  else
                  {
                      Console.SetCursorPosition(x, y);
                  }
              }
              while (true);
          }
        /// <summary>
        /// Realization Method Main with Logic Thrading
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i < 130; i++)
            {
                new Thread(new Program().Matrix).Start(i);
            }
            Thread.Sleep(1000);
            for (int i = 0; i < 130; i++)
            {
                new Thread(new Program().Matrix).Start(i);
            }
        }
  }
}
  


