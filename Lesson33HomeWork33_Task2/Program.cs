using System;
//Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет использоваться для работы с конвертером температуры
namespace Lesson33HomeWork33_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в Цельсиях");
            double temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите в какую величину конвертировать температуру 1-Кельвины 2-Форенгейты");
            int reult = int.Parse(Console.ReadLine());
            if (reult == 1)
            {
                ConvertationTemperature convertationTemperature = new Kelvins(temperature);
                convertationTemperature.ConvertTemperature();
            }
            else
            {
                ConvertationTemperature convertationTemperature = new Forengeits(temperature);
                convertationTemperature.ConvertTemperature();
            }
        }
    }
}
