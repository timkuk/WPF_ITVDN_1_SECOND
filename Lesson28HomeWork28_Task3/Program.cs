using System;
using System.Collections.Generic;
//1. Можно добавлять только Гражданина +
//2. При добавлении, элемент добавляется в конец коллекции. Если Пенсионер,то в начало с учетом ранее стоящих Пенсионеров.Возвращается номер в очереди +
//3. При добавлении одного и того же человека (проверка на равенство по номеру паспорта, необходимо переопределить метод Equals или операторы равенства для сравнения объектов по номеру паспорта) элемент не добавляется, выдается сообщение 
//4. Удаление с начала коллекции (реализовать логику)
//5. Возможно удаление с передачей экземпляра Гражданина
//6. Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и номер в очереди
//7. Метод ReturnLast возвращает последнего человека в очереди и его номер в очереди
//8. Метод Clear очищает коллекцию +
namespace Lesson28HomeWork28_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection<Сitizen> { new Student("Tim Kurchenok", "HB1111111"), new Worker("Tim Kurchenok", "HB29239193"), new Retiree("Tim Kurchenok", "HB363353535"), new Retiree("Yan Lazeba", "HB363353535") };
            int count = 0;
            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Номер в очереди {count}");
                count++;
            }
            //collection.Remove(new Student("Tim Kurchenok", "HB1111111"));
            Console.WriteLine(collection.Contains(new Retiree("Yan Lazeba", "HB363353535")));
            //collection.Clear();
        }
    }
}
