using System;
using System.Collections;
using System.Collections.Generic;
//Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и количество дней в соответствующем месяце.
//Реализуйте возможность выбора месяцев, как по порядковому номеру, так и количеству дней в месяце,результатом может быть не только один месяц
namespace Lesson28HomeWork28_Task2
{
    public class MonthCollection : IEnumerable, IEnumerator
    {
        readonly Element[] elements = new Element[12];

        public Element this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        int position = -1;

        // Реализация интерфейса IEnumerator:

        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get { return elements[position]; }
        }

        // Реализация интерфейса IEnumerable:

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}

