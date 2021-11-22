using System;
//В теле класса создайте методы void Study(), void Read(), void Write(),void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil
//и переопределите каждый из методов, в зависимости от успеваемости ученика. 
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,писать, отдыхать.
namespace Lesson12HomeWork12_Task2
{
    public class ClassRoom
    {
        public Pupil firstPupil;
        public Pupil secondPupil;
        public Pupil tirdPupil;
        public Pupil fourPupil;
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil tirdPupil, Pupil fourPupil)
        {
            this.firstPupil = firstPupil;
            this.secondPupil = secondPupil;
            this.tirdPupil = tirdPupil;
            this.fourPupil = fourPupil;
        }
    }
}
