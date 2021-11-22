using System;
//Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
//который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).
namespace Lesson19HomeWork19_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine(MyClass<int>.FacrotyMethod());
        }
    }
}
