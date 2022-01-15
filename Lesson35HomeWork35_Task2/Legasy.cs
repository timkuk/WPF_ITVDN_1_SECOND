using System;
using System.Xml.Serialization;
//Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого класса в формате XML
//Сначала используйте формат по умолчанию, а затем измените его таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML
namespace Lesson35HomeWork35_Task2
{
    [Serializable]
    public class Legasy : System.Attribute
    {
        private string fieldOfDream;
        
        //[XmlElement("Dream")]
        public string FieldOfDream
        {
            get
            {
                return fieldOfDream;
            }
            set
            {
                fieldOfDream = value;
            }
        }
    }
}
