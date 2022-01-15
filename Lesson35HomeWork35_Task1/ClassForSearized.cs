using System;
//Создайте пользовательский тип  и выполните сериализацию объекта этого типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети
namespace Lesson35HomeWork35_Task1
{
    [Serializable]
    public class ClassForSearized :System.Attribute
    {
        private string lifeField;
        public ClassForSearized(string lifeField)
        {
            this.lifeField = lifeField;
        }
        public string LifeField
        {
            get 
            { 
                return lifeField; 
            }
            set 
            { 
                lifeField = value; 
            }
        }

    }
}
