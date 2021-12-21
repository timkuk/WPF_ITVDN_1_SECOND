using System;
using System.Collections.Generic;
//Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание
//Надо создать собственный класс словаря.Только тут надо использовать уже анонимные типы
//И динамические для доступа к переменным анонимных типов
namespace Lesson26HomeWork26_Task3
{
    public class Dictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;
        int count = 0;
        public int Count { get => count; }
        public Dictionary(int Length)
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
