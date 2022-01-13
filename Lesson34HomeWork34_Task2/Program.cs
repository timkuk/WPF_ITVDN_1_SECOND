using System;
using System.Reflection;
//Создайте класс и примените к его методам атрибут Obsolete сначала в форме, просто 
//выводящей предупреждение, а затем в форме, препятствующей компиляции
//Продемонстрируйте работу атрибута на примере вызова данных методов
namespace Lesson34HomeWork34_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyObsolete myObsolete = new MyObsolete();
            myObsolete.Relese();
            Type type = typeof(MyObsolete);
            MethodInfo[] arguments = type.GetMethods(BindingFlags.Public| BindingFlags.Static);
            foreach(var info in arguments)
            {
                Console.WriteLine($"{info.Name}");
            }
        }
    }
}
