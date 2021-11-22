using System;
using System.Linq;
//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц. 
//Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
//давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.
namespace Lesson17HomeWork17_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            var EnumList = Enum.GetValues(typeof(Post)).Cast<Post>();
            foreach (var p in EnumList)
            {
                Console.WriteLine(accountant.AskForBonus(p, 120));
            }
        }
    }
}
