using System;
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение.
namespace Lesson5HomeWork5_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            Console.WriteLine(A|B);
            Console.WriteLine(A=!B);
        }
    }
}
