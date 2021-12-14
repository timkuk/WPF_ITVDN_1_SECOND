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
//Создайте приложение WPF Application, позволяющее пользователям сохранять данные в изолированное хранилище
//Реализуйте, чтобы при выборе цвета из ColorPicker в Label выводилось название выбранного цвета и в этот цвет закрашивался фон Label
//По нажатию на кнопку, данные о цвете сохраняются в изолированное хранилище
//При запуске приложения заново, цвет фона Label остается таким, каким был сохранен при предыдущих запусках приложения
namespace Lesson30HomeWork30_Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            ColorLabel.Background = new SolidColorBrush(colorPicker.SelectedColor.Value);
        }
        //private void ClrPcker_Background_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        //{
        //    ColorLabel.Background = new SolidColorBrush(colorPicker.SelectedColor.Value);
        //    //ColorLabel.Content = "#" + colorPicker.SelectedColor.R.ToString() + colorPicker.SelectedColor.G.ToString() + colorPicker.SelectedColor.B.ToString();
        //}
    }
}
