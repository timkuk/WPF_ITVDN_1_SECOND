using System;
//Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов,
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов
namespace Lesson19HomeWork19_Task3
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;
        int count = 0;
        public int Count { get => count;} 
        public MyDictionary(int Length)
        {
            key = new TKey[Length];
            value = new TValue[Length];
        }
        /// <summary>
        /// Realizationn Indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        /// <summary>
        /// Realization Method adding elements on dictionary
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool Add(TKey keys, TValue values)
        {
            if (count < key.Length)
            {
                key[count] = keys;
                value[count] = values;
                count++;
                return true;
            }
            return false;
        }
    }
}
