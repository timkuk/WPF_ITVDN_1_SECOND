using System;
using System.Text;
//Создайте структуру с именем - Notebook. 
//Поля структуры: модель, производитель, цена.
//В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.
namespace Lesson16HomeWork16_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("MackBook Pro 2008","Apple",4000);
            Console.WriteLine(notebook.OutPutInformationFields());
        }
    }
}
