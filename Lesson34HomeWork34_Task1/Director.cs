using System;
//Создай атрибут уровня доступа пользователя к системе
//При помощи атрибута AccessLevelAttribute распределите уровни доступа персонала и отобразите
//на экране реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию
namespace Lesson34HomeWork34_Task1
{
    public class Director : Staff
    {
        public Director(string WorkPositionName,string NameWorker) : base(WorkPositionName, NameWorker)
        {

        }
    }
}
