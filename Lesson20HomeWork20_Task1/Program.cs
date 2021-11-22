using System;
using System.Collections;
//В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
//переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?
namespace Lesson20HomeWork20_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ivalid Cast Exeption т.к колеллекция гетерогенная и при выводе элементов ассива как int возникает ошибка т.к int!=string
            int a = 12;
            string url = "Das Auto";
            ArrayList list = new ArrayList();
            list.Add(a);
            list.Add(url);
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine((int)list[i]);
            }
        }
    }
}
