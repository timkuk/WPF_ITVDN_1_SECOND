using System;
using System.Windows.Forms;
//Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
//Написать программу, выполняющую следующие действия:
//Ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
//Вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,вывести соответствующее сообщение).
namespace Lesson16HomeWork16_Task2
{
    public class Program
    {
        /// <summary>
        /// Realization method Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Train[] train = InputInformationAboutTrains();
            OutPutReverseArray(train);
            InputNumberTrain(train);
        }
        /// <summary>
        /// Realization Method InputInformationAboutTrains
        /// </summary>
        /// <returns></returns>
        public static Train[] InputInformationAboutTrains()
        {
            int numberTrains = 2;
            Train[] trains = new Train[numberTrains];
            for (int i = 0; i < numberTrains; i++)
            {
                Console.WriteLine("Input Information about end station");
                string nameEndStation = Console.ReadLine();
                Console.WriteLine("Input Information about nuber train");
                int nuberTrain = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Information about departure time");
                DateTime timeGoing = DateTime.Parse(Console.ReadLine());
                trains[i] = new Train(nameEndStation, nuberTrain, timeGoing);
            }
            return trains;
        }
        /// <summary>
        /// Realization method OutPutReverseArray
        /// </summary>
        /// <param name="trains"></param>
        public static void OutPutReverseArray(Train[] trains)
        {
            for (int j = 0; j < trains.Length; j++)
            {
                Train z;
                for (int s = 0; s < trains.Length; s++)
                {
                    for (int i = 0; i < trains.Length - 1; i++)
                    {
                        if (trains[i].NuberTrain > trains[i + 1].NuberTrain)
                        {
                            z = trains[i];
                            trains[i] = trains[i + 1];
                            trains[i + 1] = z;
                        }
                    }
                }
                Console.WriteLine(trains[j].ToString());
            }
        }
        /// <summary>
        /// Realization method InputNumberTrain
        /// </summary>
        /// <param name="trains"></param>
        public static void InputNumberTrain(Train[] trains)
        {
            Console.WriteLine("Input nuber train:");
            int numberTrain = int.Parse(Console.ReadLine());
            int i = 0;
            while( i < trains.Length+1)
            {
                try
                {
                    if (numberTrain == trains[i].NuberTrain)
                    {
                        Console.WriteLine($"Information about train {trains[i].NuberTrain} \n End station: {trains[i].NameEndStation} Number train: {trains[i].NuberTrain}  Departure time: {trains[i].TimeGoing}");
                        break;
                    }
                }
                catch
                { 
                    Console.WriteLine("Error this train not exist!!!");
                    break;
                }
                i++;
            }  
        }
    }
}
