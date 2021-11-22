using System;
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента. 
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове 
//соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами. 
//Обязательно используйте приведение типов.
namespace Lesson12HomeWork12_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Apokalipsis");
            Printer up = new Scanner();
            up.Print("UP Message");
            Scanner down = (Scanner)up;
            down.Print("Text Message");
            Printer printerTwo = new Printer();
            printer.Print("Apokalipsis");
        }
    }
}
