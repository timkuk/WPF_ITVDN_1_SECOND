using System;
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор. 
//Выводит на экран информацию о сотруднике фамилия, имя, должность,оклад, налоговый сбор.
namespace Lesson11HomeWork11_Task3
{
    public class Employee
    {
        public string name,sername;
        public int workExpirience;
        const double taxDirector = 0.44;
        const double taxProgrammist = 0.34;
        const double taxStaff = 0.24;
        public Employee(string name, string sername)
        {
            this.name = name;
            this.sername = sername;
        }
        public void SalaryMethod(int workExpirience)
        {
            Console.WriteLine("Iput number work position in Comany 1 - Director 2 - Staff 3 - Programmist");
            int key = Convert.ToInt32(Console.ReadLine());
            int salary = 0;
            if (key == 1)
            {
                salary = (int)((workExpirience*19*200)* taxDirector);
                Console.WriteLine($"Information abot worker sername: {sername}, name {name} position: Director salary: {salary}$ Tax collection {taxDirector}");
            }
            else if (key == 2)
            {
                salary = (int)((workExpirience * 25 * 50) * taxStaff);
                Console.WriteLine($"Information abot worker sername: {sername}, name {name} position: Staff salary: {salary}$ Tax collection {taxStaff}");
            }
            else 
            {
                salary = (int)((workExpirience * 20 * 150) * taxProgrammist);
                Console.WriteLine($"Information abot worker sername: {sername}, name {name} position: Programmist salary: {salary}$ Tax collection {taxProgrammist}");
            }
        } 
    }
}
