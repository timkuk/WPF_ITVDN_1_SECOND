using System;
//Реализуй класс который позволит выполнять мониторинг ресурсов, используемых программой
//Используйте его в целях наблюдения за работой программы, а именно: пользователь может указать приемлемые уровни потребления 
//ресурсов памяти, а методы класса позволят выдать предупреждение, когда количество используемых ресурсов приблизиться к max
namespace Lesson36HomeWork36_Task2
{
    public class Monitoring
    {
        public Monitoring()
        {
            Console.WriteLine($"Construtor working {this.GetHashCode()}");
        }
        ~Monitoring()
        {
            Console.WriteLine($"Destructor working {this.GetHashCode()}");
        }
        public bool MethodMonitoring(int maxMemoryFromUser)
        {
            try
            {
                if ((GC.GetTotalMemory(false) / 1024) + 100  >= maxMemoryFromUser)
                {
                    throw new OutOfMemoryException();
                }
                else
                {
                    Console.WriteLine($"Memory used {GC.GetTotalMemory(false) / 1024}");
                }
                return true;
            }
            catch(OutOfMemoryException ex)
            {
                Console.WriteLine("CRITICAL ERROR COUNT USE RESOURSE EXHAUSTED!!!");
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
