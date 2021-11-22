using System;
//Класс Point должен содержать два int поля и одно string поле
//Создать три свойства с одним методом доступа get
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
//PerimeterCalculator(), который рассчитывает периметр многоугольника
//Написать программу, которая выводит на экран название и периметр многоугольника
namespace Lesson10HomeWork10_Task4
{
    public class Point
    {
        public int firstInteger;
        public int secondInteger;
        public string pointText;
        public int PropertyOne
        {
            get 
            {
                return firstInteger;
            }
        }
        public int PropertyTwo
        {
            get
            {
                return secondInteger;
            }
        }
        public string PropertyString
        {
            get
            {
                return pointText;
            }
        }
        public Point(int firstInteger, int secondInteger,string pointText)
        {
            this.firstInteger = firstInteger;
            this.secondInteger = secondInteger;
            this.pointText = pointText;
        }
    }
}
