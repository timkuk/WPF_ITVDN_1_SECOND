using System;
using System.Collections;
//Создайте метод, который в качестве аргумента принимает массив целых чисел
//и возвращает коллекцию всех четных чисел массива
//Для формирования коллекции используйте оператор yield
namespace Lesson23HomeWork23_Task1
{
    public class UserCollection
    {
        /// <summary>
        /// Realization method creating custom collection using operatio yield
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public  IEnumerable MethodCollectonGenerator(int[] arrayInt)
        {
            foreach (var item in arrayInt)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }
    }
}
