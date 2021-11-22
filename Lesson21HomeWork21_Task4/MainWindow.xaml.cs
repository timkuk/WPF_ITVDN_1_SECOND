using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson21HomeWork21_Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object MousePosition { get; private set; }
        public object ClientRectangle { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler EventSum = null;
        public event EventHandler EventMinus = null;
        public event EventHandler EventMultiplicate = null;
        public event EventHandler EventDivision = null;

    
        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            EventSum.Invoke(sender, e);
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            EventMinus.Invoke(sender, e);
        }

        private void Button_Multiplicate(object sender, RoutedEventArgs e)
        {
            EventMultiplicate.Invoke(sender, e);
        }

        private void Button_Division(object sender, RoutedEventArgs e)
        {
            EventDivision.Invoke(sender, e);
        }
    }
}

