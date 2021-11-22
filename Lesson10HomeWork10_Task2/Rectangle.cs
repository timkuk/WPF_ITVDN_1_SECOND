//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
//поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника double AreaCalculator() и периметр прямоугольника double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит 
//на экран периметр и площадь.
namespace Lesson10HomeWork10_Task2
{
    public class Rectangle
    {
        public double side1, side2;

        public double Area
        {
            get
            { 
                return side1 * side2; 
            }
        }
        public double Perimeter
        {
            get
            { 
                return (side1+side2)*2; 
            }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        public double  PerimeterCalculator()
        {
            double perimetr = (side1 + side2)*2;
            return perimetr;
        }
    }
}
