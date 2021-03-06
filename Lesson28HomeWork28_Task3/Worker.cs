using System;
using System.Collections.Generic;
//1) Можно добавлять только Гражданина +
//2) При добавлении, элемент добавляется в конец коллекции. Если Пенсионер,то в начало с учетом ранее стоящих Пенсионеров.Возвращается номер в очереди 
//3) При добавлении одного и того же человека (проверка на равенство по номеру паспорта, необходимо переопределить метод Equals
//(и/или) операторы равенства для сравнения объектов по номеру паспорта) элемент не добавляется, выдается сообщение 
//4) Удаление – с начала коллекции (реализовать логику)
//5) Возможно удаление с передачей экземпляра Гражданина
//6)Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и номер в очереди
//7) Метод ReturnLast возвращsает последнего человека в очереди и его номер в очереди
//8) Метод Clear очищает коллекцию +
namespace Lesson28HomeWork28_Task3
{
    public class Worker : Сitizen
    {
        public Worker(string FullName, string PasportInformation) : base(FullName, PasportInformation)
        {
            this.FullName = FullName;
            this.PasportInformation = PasportInformation;
        }
        public override string ToString()
        {
            return $"Полное имя рабочего: {FullName}, {PasportInformation}";
        }
    }
}
