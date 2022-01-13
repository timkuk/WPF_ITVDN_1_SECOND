using System;
//Создай атрибут уровня доступа пользователя к системе
//При помощи атрибута AccessLevelAttribute распределите уровни доступа персонала и отобразите
//на экране реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию
namespace Lesson34HomeWork34_Task1
{
    [AttributeUsage(AttributeTargets.All , AllowMultiple = true)]
    public class AccessLevelAttribute : System.Attribute
    {
        private string workPosition;
        public AccessLevelAttribute(string workPosition)
        {
            this.workPosition = workPosition;
        }
        public string WorkPosition
        {
            get
            {
                return workPosition;
            }
            set
            {
                workPosition = value;
            }
        }
    }
}
