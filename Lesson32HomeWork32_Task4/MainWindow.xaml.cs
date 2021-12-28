using System;
using System.Windows;
//В главном окне поместите любой текст.Также,должно быть окно настроек (можно реализовать с помощью TabControl)
//Пользователь может изменять настройки. При повторном запуске приложения настройки должны оставаться прежними
//1) сохранение настроек в конфигурационном файле
namespace Lesson32HomeWork32_Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.IDField = tb1.Text;
            information.LoginField = tb2.Text;
            information.PasswordField = tb3.Text;
            SaveXML.SaveingXML(information, @"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson32HomeWork32_Task4\Information.xml");
        }
    }
}
