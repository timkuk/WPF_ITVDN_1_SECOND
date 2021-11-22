using System;
//Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>.
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов
namespace Lesson19HomeWork19_Task2
{
    public class MyList<T>
    {
        private  int count;
        public T[] myList;
        public int AllCountElements { get; }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count =  value;
            }
        }
        public MyList(int count,T[] myList)
        {
            this.myList = new T[count];
            this.count = count;
            AllCountElements = count;
        }
        public T this[int index]
        {
            get
            {
                return myList[index];
            }
            set
            {
                myList[index] = value;
            }
        }
        public void AddMethod(object value)
        {
            Console.WriteLine($"Element add in MyList");
            Console.WriteLine(value);
        }
        public void OutPutAllElements(int countElements)
        {
            for(int i=0;i< countElements; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
