using System;
using System.Collections.Generic;
using System.Text;
//Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его 
//экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
namespace Lesson20HomeWork20_Task4
{
    public class ArrayList
    {
        private int[] arraylist;
        int count = 0;
        public int Count { get => count; }
        public ArrayList(int length)
        {
            arraylist = new int[length];
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arraylist.Length)
                    return $"{arraylist[index]}";
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public bool Add(int argument)
        {
            if (count < arraylist.Length)
            {
                arraylist[count] = argument;
                count++;
                return true;
            }
            return false;
        }
    }
}
