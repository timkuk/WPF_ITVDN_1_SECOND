using System;
//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц. 
//Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
//давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.
namespace Lesson17HomeWork17_Task3
{
    public enum Post
    {
        Programmist = 160,
        Menanger = 180,
        BuisnesAnalyst = 90,
        TimLid = 70
    }
}
