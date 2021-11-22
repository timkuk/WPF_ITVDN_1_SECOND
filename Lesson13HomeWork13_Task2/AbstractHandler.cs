using System;
//Написать программу, которая будет выполнять определение документа и для каждого формата должны 
//быть методы открытия, создания, редактирования, сохранения определенного формата документа.
namespace Lesson13HomeWork13_Task2
{
    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
}
