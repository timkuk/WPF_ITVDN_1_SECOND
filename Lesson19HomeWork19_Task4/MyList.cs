using System;

namespace Lesson19HomeWork19_Task4
{
    public class MyList<T>
    {
        private int count;
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
                count = value;
            }
        }
        public MyList(int count, T[] myList)
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
            Console.WriteLine(value);
        }
        public void OutPutAllElements(int countElements)
        {
            for (int i = 0; i < countElements; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
