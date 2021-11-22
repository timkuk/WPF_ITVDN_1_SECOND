//Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.
//Для каждого поля, создать свойство с двумя методами доступа. 
//Создать экземпляр класса Address. 
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
namespace Lesson10HomeWork10_Task1
{
    public class Adress
    {
        public int index;
        public string country;
        public string city;
        public string street;
        public int house;
        public int apartment;
        public int PropertyIndex
        {
            get
            {
                return index;
            }
            set 
            {
                index = value;
            }
        }
        public string PropertyCountry
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string PropertyCity
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string PropertyStreet
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int PropertyHouse
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int PropertyApartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
}
