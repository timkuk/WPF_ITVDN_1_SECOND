using System;
//Используя циклы и метод:
//Console.Write("*"), Console.Write(" "), Console.Write("\n")(для перехода на новую строку).
//Выведите на экран:
//• прямоугольник
//• прямоугольный треугольник 
//• равносторонний треугольник 
//• ромб
namespace Lesson6HomeWork6_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region rectangle
            Console.WriteLine("Enter weight figure");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hight figure");
            int hight = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hight; i++)
            {

                for (int j = 0; j < weight; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
            #endregion

            #region right triangle
            Console.WriteLine("Enter first side figure:");
            int hightTriangle = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < hightTriangle; k++)
            {
                for (int p = 0; p < k; p++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            #endregion
            #region triangle

            for (int k = 0; k < hightTriangle; k++)
            {
                if (k == 0)
                {
                    Console.Write(new string(' ', hightTriangle - k) + new string('*', k + 1));
                }
                Console.Write(new string(' ', hightTriangle - k) + new string('*', k * 3));
                Console.Write("\n");
            }
            #endregion

            #region rhomb
            Console.WriteLine("Input diagonal longest rhomb integer number:");
            int diagonal = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < diagonal; k++)
            {
                int backSpace = (int)Math.Abs(diagonal / 2 - k);
                int quatityStars = diagonal - 2 * backSpace;
                Console.WriteLine(new string(' ', backSpace) + new string('*', quatityStars));
            }
            #endregion
        }
    }
}
