using System;
//Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
//В классе Program создайте два метода: 
//static void ClassTaker(MyClass myClass)    ,    который присваивает полю change экземпляра myClass значение «изменено».
//static void StruktTaker(MyStruct myStruct) , который присваивает полю change экземпляра myStruct значение «изменено».
//Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
//структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы 
//ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.
namespace Lesson16HomeWork16_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //У класса ссылки завият друг от друга ,при изменениии одноой ссылки меняется и другая ссылка
            MyClass myClass = new MyClass("Не изменено");
            ClassTaker(myClass);
            Console.WriteLine(myClass.change);
            //Если изменить одну копию структуры то другая копия не поменяется
            MyStruct myStruct = new MyStruct("Не изменено");
            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change);
        }
        static void ClassTaker(MyClass myClass)
        {
            Console.WriteLine(myClass.change = "Изменено");
        }
        static void StruktTaker(MyStruct myStruct)
        {
            Console.WriteLine(myStruct.change = "Изменено");
        }
    }
}
