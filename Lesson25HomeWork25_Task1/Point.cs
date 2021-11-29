using System;
//Создайте структуру описывающую точку в трехмерной системе координат
//Организуйте возможность сложения двух точек, через использование перегрузки оператора +
namespace Lesson25HomeWork25_Task1
{
    public class Point
    {
        public  int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
       
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Realization Method sum
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1} ,{2}]", this.x, this.y, this.z);
        }
    }
}
