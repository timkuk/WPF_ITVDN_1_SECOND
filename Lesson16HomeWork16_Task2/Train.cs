using System;
//Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
//Написать программу, выполняющую следующие действия:
//Ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
//Вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,вывести соответствующее сообщение).
namespace Lesson16HomeWork16_Task2
{
    public struct Train
    {
        private string nameEndStation;
        private int nuberTrain;
        private DateTime timeGoing;
        public string NameEndStation
        {
            get
            {
                return nameEndStation;
            }
            set
            {
                nameEndStation = value;
            }
        }
        public int NuberTrain
        {
            get
            {
                return nuberTrain;
            }
            set
            {
                nuberTrain = value;
            }
        }
        public DateTime TimeGoing
        {
            get
            {
                return timeGoing;
            }
            set
            {
                timeGoing = value;
            }
        }
        public Train(string nameEndStation, int nuberTrain, DateTime timeGoing)
        {
            this.nameEndStation = nameEndStation;
            this.nuberTrain = nuberTrain;
            this.timeGoing = timeGoing;
        }
        public  override string ToString()
        {
            return $"Information about train \n End station: {nameEndStation} Number train: {nuberTrain}  Departure time: {timeGoing}";
        }
    }
}
