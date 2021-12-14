using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.IsolatedStorage;
using System.IO;
using System.Drawing;
/// <summary>
/// Программа работает следующим образом при выборе цвета нужно нажать на кнопку и выведется название цвета и label перекрасится в выбранный цвет
/// Перезапускаем приложение нажимаем на кнопку и выводится предыдущий увет который мы сохранили в изолированное хранилище
/// </summary>
namespace Lesson30HomeWork30_Task5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Realization logic working color button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.OpenOrCreate, isoStore);
            StreamReader userReader1 = new StreamReader(userStream);
            string value = userReader1.ReadToEnd();
            if (value == "")
            {
                LabelColor.Background = new SolidColorBrush(colorPicker.SelectedColor.Value);
                LabelColor.Content = LabelColor.Background.ToString();
                StreamWriter userWriter = new StreamWriter(userStream);
                userWriter.WriteLine(LabelColor.Background);
                userWriter.Close();
                userStream.Close();
            }
            else
            {
                userStream.Close();
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, isoStore);
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                LabelColor.Content = contents.ToString();
                System.Windows.Media.Color color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(contents);
                LabelColor.Background = new SolidColorBrush(color);
                StreamWriter userWriter = new StreamWriter(userStream);
                userWriter.WriteLine($"{LabelColor.Background.ToString()}");
                userWriter.Close();
                userStream.Close();
            }
        }
    }
}
