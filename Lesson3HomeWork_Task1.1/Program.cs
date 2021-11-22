using System;

namespace Lesson3HomeWork_Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.Write(x);
            z = --x - y * 5;
            Console.Write(z);
            y /= x + 5 % z;
            Console.Write(y);
            z = x++ + y * 5;
            Console.Write(z);
            x = y - x++ * z;
            Console.Write(x);
        }
    }
}
