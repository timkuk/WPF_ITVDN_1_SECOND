using System;
//Создайте класс House c двумя полями и свойствами
//Создайте два метода Clone() и DeepClone(),которые выполняют поверхностное и глубокое копирование соответственно
//Реализуйте простой способ проверки
namespace Lesson25HomeWork25_Task3
{
    public class House 
    {
        private int firstField;
        private int secondField;
        public int FirstField
        {
            get
            {
                return firstField;
            }
            set
            {
                firstField = value;
            }
        }
        public int SecondField
        {
            get
            {
                return secondField;
            }
            set
            {
                secondField = value;
            }
        }
    }
}
