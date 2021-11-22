using System;
using System.Windows.Threading;
//Создайте программу секундомер. Требуется выводить показания секундомера в окне. Окно имеет 
//кнопки запуска, остановки и сброса секундомера. Для реализации секундомера используйте паттерн MVP
namespace Lesson21HomeWork21_Task3
{
    public class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.Tick += new EventHandler(TimerHandler);
        }
        public void TimerHandler(object sender, EventArgs e)
        { 
            int MaxValue = 400;
            if (this.view.EventProgressBar.Value < MaxValue)
            {
                this.view.EventProgressBar.Value += 2;
            }
        }
    }
}
