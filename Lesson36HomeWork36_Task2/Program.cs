﻿using System;
using System.Threading;
//Реализуй класс который позволит выполнять мониторинг ресурсов, используемых программой
//Используйте его в целях наблюдения за работой программы, а именно: пользователь может указать приемлемые уровни потребления 
//ресурсов памяти, а методы класса позволят выдать предупреждение, когда количество используемых ресурсов приблизиться к max
namespace Lesson36HomeWork36_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input normal level using total memory in  program");
            int input = int.Parse(Console.ReadLine());
            Monitoring @object = new Monitoring();
            GarbechingHeap garbechingHeap = new GarbechingHeap();
            new Thread(garbechingHeap.MethodGarbechingHeap).Start();
            while(true)
            {
                bool answer = @object.MethodMonitoring(input);
                if (answer == false)
                {
                    break;
                }
            }
        }
    }
}
