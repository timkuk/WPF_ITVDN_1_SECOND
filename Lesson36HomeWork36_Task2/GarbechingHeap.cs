using System;
//Реализуй класс который позволит выполнять мониторинг ресурсов, используемых программой
//Используйте его в целях наблюдения за работой программы, а именно: пользователь может указать приемлемые уровни потребления 
//ресурсов памяти, а методы класса позволят выдать предупреждение, когда количество используемых ресурсов приблизиться к max
namespace Lesson36HomeWork36_Task2
{
    public class GarbechingHeap
    {
        public void MethodGarbechingHeap()
        {
            GarbechingHeap[] garbechingHeaps = new GarbechingHeap[1000];
            for(int i = 0; i < 50; i++)
            {
                garbechingHeaps[i] = new GarbechingHeap();
            }
        }
    }
}
