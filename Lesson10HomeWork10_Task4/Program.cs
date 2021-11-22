using System;
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника
//PerimeterCalculator(), который рассчитывает периметр многоугольника
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace Lesson10HomeWork10_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(12, 24, "Test text");
            Figure figure = new Figure(point, point,"text drfenition");
            Console.WriteLine(figure.LengthSide(point, point));
            figure.PerimeterCalculator();
        }
    }
}
