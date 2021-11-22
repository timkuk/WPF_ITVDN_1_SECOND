using System;
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности:
//• вывод информации о товаре по номеру с помощью индекса;
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,выдать соответствующее сообщение;
//Написать программу, вывода на экран информацию о товаре.
namespace Lesson14HomeWork14_Task4
{
    public class Store
    {
        private Article[] articles;
        /// <summary>
        /// Реализация пользовательского конструктора
        /// </summary>
        /// <param name="count"></param>
        public Store(int count)
        {
            articles = new Article[count];
            for (int i = 0; i < articles.Length; i++)
            {
                articles[i] = new Article("Xiaomi Mi Notebook Pro", "XI Store", 820);
            }
        }
        /// <summary>
        /// Реализация Индексатора
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Article this[int index]
        {
            get
            {
                return articles[index];
            }
            set
            {
                articles[index] = value;
            }
        }
    }
}
