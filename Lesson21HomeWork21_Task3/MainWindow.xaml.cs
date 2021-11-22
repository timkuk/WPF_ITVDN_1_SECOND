using System;
using System.Windows;
using System.Windows.Threading;

namespace Lesson21HomeWork21_Task3
{
    /// <summary>
    /// Realization Timer Event logic
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler Tick = null;
        DispatcherTimer timer = new DispatcherTimer();
        /// <summary>
        /// Инициализация компонентов 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
            InitializeTimer();
        }
       
        private void InitializeTimer()
        {
                //Интервал движения таймера
                timer.Interval = TimeSpan.FromMilliseconds(120);
                //Запуск Таймера
                timer.Start();
                //Статус таймера
                timer.IsEnabled = false;
                timer.Tick += timer1_Tick;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick.Invoke(sender, e);
        }
        /// <summary>
        /// Реализация метода запуска таймера,деление прибавлется какждый раз при нажатии на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void Button_START(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = true;
        }
        /// <summary>
        /// Реализация метода остановки таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
        }
        /// <summary>
        /// Реализация метода перезагрузки таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_RECET(object sender, RoutedEventArgs e)
        {
            EventProgressBar.Value = 0;
        }
    }
}
