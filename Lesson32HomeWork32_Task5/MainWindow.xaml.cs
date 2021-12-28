using System;
using System.Windows;

namespace Lesson32HomeWork32_Task5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.IDField = tb1.Text;
            information.LoginField = tb2.Text;
            information.PasswordField = tb3.Text;
            SaveXML.SaveingXML(information, "information.xml");
        }
    }
}
