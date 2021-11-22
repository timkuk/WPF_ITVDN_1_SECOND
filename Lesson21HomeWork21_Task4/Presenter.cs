using System;
using System.Collections.Generic;
using System.Text;
//Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и деление). 
//Для реализации калькулятора используйте паттерн MVP
namespace Lesson21HomeWork21_Task4
{
    public class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.EventSum += new EventHandler(HandlerSum);
            this.view.EventMinus += new EventHandler(HandlerMinus);
            this.view.EventMultiplicate += new EventHandler(HandlerMultiplication);
            this.view.EventDivision += new EventHandler(HandlerDivision);
        }

        public void HandlerSum(object sender, System.EventArgs e)
        {
            var number1 = this.view.tb1.Text;
            var number2 = this.view.tb2.Text;
            var sum = model.MethodSum(number1, number2);
            string convertSum = Convert.ToString(sum);
            this.view.tb3.Text = convertSum;
        }
        public void HandlerMinus(object sender, System.EventArgs e)
        {
            var number1 = this.view.tb1.Text;
            var number2 = this.view.tb2.Text;
            var minus = model.MethodMinus(number1, number2);
            string convertMinus = Convert.ToString(minus);
            this.view.tb3.Text = convertMinus;
        }
        public void HandlerMultiplication(object sender, System.EventArgs e)
        {
            var number1 = this.view.tb1.Text;
            var number2 = this.view.tb2.Text;
            var multiplicate = model.MethodMultiplication(number1, number2);
            string convertMultiplicate = Convert.ToString(multiplicate);
            this.view.tb3.Text = convertMultiplicate;
        }
        public void HandlerDivision(object sender, System.EventArgs e)
        {
            var number1 = this.view.tb1.Text;
            var number2 = this.view.tb2.Text;
            var division = model.MethodDivision(number1, number2);
            string convertDivision = Convert.ToString(division);
            this.view.tb3.Text = convertDivision;
        }
    }
}
