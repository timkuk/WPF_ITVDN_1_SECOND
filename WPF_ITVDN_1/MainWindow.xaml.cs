using System.Windows;
//Используя Visual Studio, создайте проект по шаблону WPF Application. 
//Откройте дизайнер форм и поместите на форму два элемента управления TextBox и один элемент 
//управления Button.
//Дважды кликните левой кнопкой мыши по элементу управления Button. В Code Behind, в методе 
//обработчике события нажатия на кнопку – button_Click, напишите строку кода, которая будет выводить в 
//textBox2, значение, которое пользователь введет в textBox1.
namespace WPF_ITVDN_1
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
        /// <summary>
        /// Реализация метода оброботчика события нажатия на кнопку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tb2.Text = tb1.Text, "Благодарю за проверку!");
        }
    }
}
