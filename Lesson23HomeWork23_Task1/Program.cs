﻿using System;
using System.Collections;
//Создайте метод, который в качестве аргумента принимает массив целых чисел
//и возвращает коллекцию всех четных чисел массива
//Для формирования коллекции используйте оператор yield
namespace Lesson23HomeWork23_Task1
{
    public class Program
    {
        static void Main()
        {
            UserCollection user = new UserCollection();
            int[] intArray = new int[] { 1, 2, 3, 4, 100, 120,113};
            Console.WriteLine("Sorted collection:");
            foreach (var item in user.MethodCollectonGenerator(intArray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
