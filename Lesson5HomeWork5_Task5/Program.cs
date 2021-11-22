using System;
//Выполните и рассчитайте результат следующих операций для этих переменных: 
// x += y >> x++ * z; 
// z = ++x & y * 5; 
// y /= x + 5 | z; 
// z = x++ & y * 5; 
// x = y << x++ ^ z;
namespace Lesson5HomeWork5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine(x += y >> x++ * z);
            Console.WriteLine(z = ++x & y * 5);
            Console.WriteLine(y /= x + 5 | z);
            Console.WriteLine(z = x++ & y * 5);
            Console.WriteLine(x = y << x++ ^ z); 
        }
    }
}
