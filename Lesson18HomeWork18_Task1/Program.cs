using System;
//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
namespace Lesson18HomeWork18_Task1
{
    public delegate double DelegateforAnonymy(ref int a,ref int b,ref int c);
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1; int b = 2; int c = 3;
            DelegateforAnonymy delegateforAnonymy;
            delegateforAnonymy = delegate (ref int a, ref int b, ref int c) { return (a + b + c) / 3; };
            Console.WriteLine(delegateforAnonymy(ref a, ref b, ref c));
        }
    }
}
