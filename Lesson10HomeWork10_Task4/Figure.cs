using System;
//Класс Point должен содержать два целочисленных поля и одно строковое поле +
//Создать три свойства с одним методом доступа get +
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов +
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину 
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace Lesson10HomeWork10_Task4
{
    public class Figure
    {
        public Point A,B;
        public string TextFigure;
        public Figure(Point firstInteger, Point secondInteger, string TextFigure)
        {
            A = firstInteger;
            B = secondInteger;
            this.TextFigure = TextFigure;
        }
        /// <summary>
        /// Realization Method LengthSide
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public double LengthSide(Point A, Point B)
        {
            double lengthSide = B.firstInteger - A.secondInteger;
            return lengthSide;
        }
        /// <summary>
        /// Realization Method PerimeterCalculator
        /// </summary>
        public void PerimeterCalculator()
        {
            double perimetr = (B.firstInteger + A.secondInteger)*2;
            Console.WriteLine(perimetr);
        }
    }
}
