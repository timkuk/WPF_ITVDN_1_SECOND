using System;
//Числа, которые являются степенью двойки, только один бит имеет значение 1. 
//Напишите программу, которая будет выполнять проверку –
//является ли указанное число степенью двойки или нет
namespace Lesson5HomeWork5_Task1
{
    //Task - cool
    public class BitOperation
    {
        public bool IsPowerOfTwo(int number)
        {
            return number > 0 && (number & -number) == number;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            BitOperation bin = new BitOperation();
            Console.WriteLine(bin.IsPowerOfTwo(9));
        }

        //Console.WriteLine("Enter number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //byte mask = 0b_0000_0100;//4
        //int k = (int)mask;
        //Console.WriteLine(k);
    }
 }


