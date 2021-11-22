using System;
//Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
//который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т)
namespace Lesson19HomeWork19_Task1
{
    public class MyClass<T>
    {
        public static MyClass<T> FacrotyMethod() 
        {
            return new MyClass<T>();
        }
    }
}
