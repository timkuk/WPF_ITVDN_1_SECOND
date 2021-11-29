using System;
//Создайте класс Block с 4-мя полями сторон, переопределите в нем методы: 
//Equals – способный сравнивать блоки между собой,ToString – возвращающий информацию о полях блока.
namespace Lesson25HomeWork25_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block(1, 2, 3, 4);
            Block block1 = new Block(1, 2, 3, 4);
            Console.WriteLine(block.ToString());
            Console.WriteLine(block.Equals(block1));
            Console.WriteLine($"HashCode select object {block.GetHashCode()}");
        }
    }
}
