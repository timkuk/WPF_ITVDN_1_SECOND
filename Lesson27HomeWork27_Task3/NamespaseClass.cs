using System;
using System.Collections.Generic;
using Lesson27HomeWork27_Task3;
//Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному 
//методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки
namespace Lesson27HomeWork27_Task3
{
    /// <summary>
    /// Вызываю метод NameSpaceMethod из проекта 1 задания,в результате наследования удалось вызват метод из другой сборки
    /// </summary>
    public class NamespaseClass 
    {
        public void NameSpaceMethod()
        {
            Console.WriteLine("You can use this METHOD!!");
        }
    }
}
