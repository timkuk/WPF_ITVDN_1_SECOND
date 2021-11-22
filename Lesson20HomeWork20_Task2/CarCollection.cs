using System;
using System.Collections.Generic;
using System.Text;
//Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин
//Требуемый интерфейс должен включать метод добавления машин с названием машины и года ее выпуска,  
//индексатор для получения значения элемента по указанному индексу и свойство только для 
//чтения для получения общего количества элементов.Создайте метод удаления всех машин автопарка
namespace Lesson20HomeWork20_Task2
{
    public class CarCollection<T>
    {
        private string[] stringName;
        private DateTime[] dateCreation;
        private T[] cars;
        int count = 0;
        public int Count { get => count; }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < stringName.Length)
                    return cars[index] + stringName[index] + " - " + dateCreation[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public CarCollection(int length)
        {
            stringName = new string[length];
            dateCreation = new DateTime[length];
            cars = new T[length];
        }
        public bool Add(T car,string stringNames, DateTime dateCreations)
        {
                if (count < stringName.Length)
                {
                    cars[count] = car;
                    stringName[count] = stringNames;
                    dateCreation[count] = dateCreations;
                    count++;
                    return true;
                }
                return false;
         }
        public void Remove()
        {
            Console.WriteLine("All cars removed!");
            Array.Clear(stringName,0,Count);
            Array.Clear(dateCreation, 0, Count);
            Array.Clear(cars, 0, Count);
        }
    }
}
