using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//1) Можно добавлять только Гражданина +
//2) При добавлении, элемент добавляется в конец коллекции. Если Пенсионер,то в начало с учетом ранее стоящих Пенсионеров.Возвращается номер в очереди 
//3) При добавлении одного и того же человека (проверка на равенство по номеру паспорта, необходимо переопределить метод Equals
//(и/или) операторы равенства для сравнения объектов по номеру паспорта) элемент не добавляется, выдается сообщение 
//4) Удаление – с начала коллекции (реализовать логику)
//5) Возможно удаление с передачей экземпляра Гражданина
//6)Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и номер в очереди
//7) Метод ReturnLast возвращsает последнего человека в очереди и его номер в очереди
//8) Метод Clear очищает коллекцию +
namespace Lesson28HomeWork28_Task3
{
    public class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];
        public void Add(T item)
        {
            if (elements.Equals(item))
            {
                throw new NotImplementedException("Такой гражданин уже существует");
            }
            else
            {
                if (typeof(Retiree) == item.GetType())
                {
                    var newArray = new T[elements.Length + 1];
                    elements.CopyTo(newArray, 1);
                    newArray[0] = item;
                    elements = newArray;
                }
                else
                {
                    var newArray = new T[elements.Length + 1];
                    elements.CopyTo(newArray, 0);
                    newArray[newArray.Length - 1] = item;
                    elements = newArray;
                }
            }
        }
        /// <summary>
        /// Удаление всех элементов коллекции
        /// </summary>
        public void Clear()
        {
            elements = new T[0];
        }

        // Определяет, содержит ли интерфейс ICollection<T> указанное значение.
        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }
            return elements.Contains(item);
        }

        // Копирует элементы ICollection<T> в Array, начиная с конкретного индекса Array.
        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        // Получает число элементов, содержащихся в интерфейсе ICollection<T>.
        public int Count
        {
            get { return elements.Length; }
        }

        // Получает значение, указывающее, доступна ли ICollection<T> только для чтения.
        public bool IsReadOnly
        {
            get { return false; }
        }

        // Удаляет первое вхождение указанного объекта из коллекции ICollection<T>.
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        // Возвращает перечислитель, выполняющий перебор элементов в коллекции.  (Унаследовано от IEnumerable<T>.)
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        // Возвращает перечислитель, который выполняет итерацию по элементам коллекции. (Унаследовано от IEnumerable)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
        //public override bool Equals(Сitizen сitizen)
        //{
        //    if (object.ReferenceEquals(сitizen.PasportInformation, this))
        //        return true;
        //    return false;
        //}
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
