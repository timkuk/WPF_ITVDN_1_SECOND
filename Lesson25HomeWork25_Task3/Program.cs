using System;
//Создайте класс House c двумя полями и свойствами
//Создайте два метода Clone() и DeepClone(),которые выполняют поверхностное и глубокое копирование соответственно
//Реализуйте простой способ проверки
namespace Lesson25HomeWork25_Task3
{
    public class Program :House
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DeepClone();
            program.Clone();
        }
        /// <summary>
        /// Реализация метода глубокого копирования
        /// </summary>
        public  void DeepClone()
        {
            Program original = new Program();
            original.FirstField = 12;
            original.SecondField = 25;
            Console.WriteLine($"Глубокое копирование\n{original.FirstField} {original.SecondField}");
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine($"Глубокое копирование\n{clone.FirstField} {clone.SecondField}");
            clone.FirstField = 120;
            clone.SecondField = 250;
            Console.WriteLine($"Глубокое копирование\n{ original.FirstField } {original.SecondField}");
            Console.WriteLine($"Глубокое копирование\n{clone.FirstField} {clone.SecondField}");
            bool result = clone.FirstField.Equals(original.FirstField);
            if (result == false)
            {
                Console.WriteLine("Объекты склонировались правильно совпадений нет");
            }
            else
            {
                Console.WriteLine("Метод копирования не сработал объекты одинаковые");
            }
        }
        /// <summary>
        /// Реализация метода поверхностного копирования
        /// </summary>
        public  void Clone()
        {
            Program original = new Program();
            original.FirstField = 1200;
            original.SecondField = 22455;
            Console.WriteLine($"Поверностное копирование\n{original.FirstField} {original.SecondField}"); ;
            Program clone = original;
            Console.WriteLine(clone.FirstField + " " + clone.SecondField);
            clone.FirstField = 0;
            clone.SecondField = -100;
            Console.WriteLine($"Поверностное копирование\n{original.FirstField} {original.SecondField}");
            Console.WriteLine(clone.FirstField + " " + clone.SecondField);
            bool result1 = original.Equals(clone);
            if (result1 == true)
            {
                Console.WriteLine("Объекты склонировались правильно совпадений нет");
            }
            else
            {
                Console.WriteLine("Метод копирования не сработал объекты одинаковые");
            }
        }
        public override bool Equals(object item)
        {
            if (this.GetHashCode() != item.GetHashCode())
            {
                return true;
            }
            return false;
        }
    }
}
