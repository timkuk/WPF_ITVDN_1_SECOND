using System;
//Создайте свой класс, объекты которого будут занимать много места в памяти (например, в коде класса будет присутствовать большой массив) 
//и реализуйте для этого класса,формализованный шаблон очистки
namespace Lesson36HomeWork36_Task1
{
    public class Garbage
    {
        /// <summary>
        /// Realization Distructor
        /// </summary>
        ~Garbage()
        {
            Console.WriteLine("Distructor working");
        }
        Array array = new int[10000];

    }
}
