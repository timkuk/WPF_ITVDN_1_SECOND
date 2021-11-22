using System;
//Создайте структуру с именем - Notebook. 
//Поля структуры: модель, производитель, цена.
//В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.
namespace Lesson16HomeWork16_Task1
{
    public struct Notebook
    {
        private string model;
        private string creator;
        private double price;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Creator
        {
            get
            {
                return creator;
            }
            set
            {
                creator = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public Notebook(string model,string creator,double price)
        {
            this.model = model;
            this.creator = creator;
            this.price = price;
        }
        public string OutPutInformationFields()
        {
            return $"Information about product :Model -> {Model} Creator -> {Creator} Price -> {Price}$";
        }
    }
}
