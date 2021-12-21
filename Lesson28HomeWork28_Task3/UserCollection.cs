using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте абстрактный класс Гражданин. Создайте классы Студент, Пенсионер, Рабочий 
//унаследованные от Гражданина. Создайте непараметризированную коллекцию со следующим функционалом: 
//1.Добавление элемента в коллекцию. 
//1) Можно добавлять только Гражданина. 
//2) При добавлении, элемент добавляется в конец коллекции. Если Пенсионер, – то в 
//начало с учетом ранее стоящих Пенсионеров. Возвращается номер в очереди. 
//3) При добавлении одного и того же человека (проверка на равенство по номеру 
//паспорта, необходимо переопределить метод Equals и/или операторы равенства для 
//сравнения объектов по номеру паспорта) элемент не добавляется, выдается сообщение. 
//2. Удаление 
//1) Удаление – с начала коллекции. 
//2) Возможно удаление с передачей экземпляра Гражданина
//3.Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и 
//номер в очереди. 
//4. Метод ReturnLast возвращsает последнего чеолвека в очереди и его номер в очереди. 
//5. Метод Clear очищает коллекцию. 
//6. С коллекцией можно работать опертаором foreach
namespace Lesson28HomeWork28_Task3
{
    public class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];

        // Добавляет элемент в интерфейс ICollection<T>.
        public void Add(T item)
        {
            if (item == )
            {

            }
            else
            {
                var newArray = new T[elements.Length + 1]; // Создание нового массива (на 1 больше старого).
                elements.CopyTo(newArray, 0);              // Копирование старого массива в новый.
                newArray[newArray.Length - 1] = item;      // Помещение нового значения в конец массива.
                elements = newArray;
            }                   
        }

        // Удаляет все элементы из коллекции ICollection<T>.
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

            return false;

            ////Or we can use LINQ :)
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
    }
}
