using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
//коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции используйте оператор yield
namespace Lesson28HomeWork28_Task1
{
    public class MyCollection
    {
        public IEnumerable MethodCollectonGenerator(int[] arrayInt)
        {
            foreach (var item in arrayInt)
            {
                if (item % 2 != 0)
                {
                    yield return Math.Pow(item,2);
                }
            }
        }
    }
}
