using System;
//Создайте свой класс, объекты которого будут занимать много места в памяти (например, в коде класса будет присутствовать большой массив) 
//и реализуйте для этого класса,формализованный шаблон очистки
namespace Lesson36HomeWork36_Task1
{
    public class AllGarbage
    {
        byte[] garbageArray = new byte[1024 * 100];
        /// <summary>
        /// Method inputing new objects to array
        /// </summary>
        public void InputOnArray()
        {
            AllGarbage[] allGarbages = new AllGarbage[1000];
            for (int i = 0; i < allGarbages.Length; i++)
            {
                 allGarbages[i] = new AllGarbage();
                 //AllGarbage all = new AllGarbage();
            }
        }
    }
}
