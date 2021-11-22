using System;
using System.Windows.Forms;

/// <summary>
//Используя Visual Studio, создайте проект по шаблону Windows Forms. Разместите на форме 8 кнопок с 
//названиями целых типов. В обработчиках события нажатия на каждую кнопку напишите следующий код 
//– MessageBox.Show("сюда можно вписать текст"); и выполните программу. 
//После успешного выполнения программы, удалите строки – "сюда можно вписать текст" из 
//каждого обработчика и вместо них укажите диапазон допустимых значений для соответствующих типов. 
//Запустите приложение.
/// </summary>
namespace WFA_TASK_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0<=x<=65535");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32768<=x<=32767");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0<=x<=4294967295");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0<=x<=18 446 744 073 709 551 615 ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("–9 223 372 036 854 775 808 <=x<= 9 223 372 036 854 775 807");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128 <=x<= 127 ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 0<=x<=255");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2147483648<=x<=2147483647");
        }
    }
}
