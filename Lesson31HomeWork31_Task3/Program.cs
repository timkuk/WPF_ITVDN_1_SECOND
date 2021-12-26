using System;
using System.Text.RegularExpressions;
//Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы заменить все предлоги на слово «ГАВ!».
namespace Lesson31HomeWork31_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            //нужно чтобы предлог (слово 1-3 символа) замелось на ГАВ! 
            string result = Regex.Replace(text, @"\b(\w){1,3}\b", "ГАВ!");
            Console.WriteLine(result);
        }
    }
}
