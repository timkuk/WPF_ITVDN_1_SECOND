using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22HomeWork22_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 5;
            char[,] a = new char[5, 5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = (char)rand.Next(0x021, 0x07E);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
