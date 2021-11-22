using System;
//Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции.
namespace Lesson15HomeWork15_Task1
{
    static class Calculator
    {
        public static int MethodSum(int a,int b)
        {
            return a + b;
        }
        public static int MethodMinus(int a, int b)
        {
            return a - b;
        }
        public static int MethodMultiplication(int a, int b)
        {
            return a * b;
        }
        public static int MethodDivisions(int a, int b)
        {
            return a / b;
        }
    }
}
