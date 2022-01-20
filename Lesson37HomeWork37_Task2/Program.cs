using System;
//Выучите описание шаблона Шаблонный метод. Обратите внимание на применимость шаблона, а также
//на состав его участников и связи отношения между ними. Напишите небольшую программу, представляющую собой абстрактную реализацию данного шаблона
namespace Lesson37HomeWork37_Task2
{
    public class  Program
    {
        static void Main(string[] args)
        {
            Bitcoin bitcoin = new Bitcoin();
            Ephirium ephirium = new Ephirium();
            bitcoin.AllSettings();
            Console.WriteLine(new string('-', 40));
            ephirium.AllSettings();
        }
    }
}
