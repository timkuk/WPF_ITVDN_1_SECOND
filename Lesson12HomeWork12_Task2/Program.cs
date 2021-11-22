using System;
//В теле класса создайте методы void Study(), void Read(), void Write(),void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil
//и переопределите каждый из методов, в зависимости от успеваемости ученика. 
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,писать, отдыхать.
namespace Lesson12HomeWork12_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pupil badPupil = new BadPupil("Kin Kardashan");
            Pupil goodPupil = new GoodPupil("Jeck Vorobey");
            Pupil exelentPupil = new ExcelentPupil("Stive Jobs");
            Pupil exelentPupil2 = new ExcelentPupil("Poll Alen");
            ClassRoom classRoom = new ClassRoom(badPupil, goodPupil, exelentPupil,exelentPupil2);
            classRoom.firstPupil.Read();
            classRoom.secondPupil.Read();
            classRoom.tirdPupil.Read();
            classRoom.fourPupil.Read();

            classRoom.firstPupil.Write();
            classRoom.secondPupil.Write();
            classRoom.tirdPupil.Write();
            classRoom.fourPupil.Write();

            classRoom.firstPupil.Study();
            classRoom.secondPupil.Study();
            classRoom.tirdPupil.Study();
            classRoom.fourPupil.Study();

            classRoom.firstPupil.Relax();
            classRoom.secondPupil.Relax();
            classRoom.tirdPupil.Relax();
            classRoom.fourPupil.Relax();
        }
    }
}
