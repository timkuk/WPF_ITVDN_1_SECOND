using System;
using System.Windows.Forms;

namespace Lesson8HomeWork8_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            if (radioButton1.Checked)
            {
                res = int.Parse(textBox1.Text) % int.Parse(textBox2.Text);
                textBox3.Text = res.ToString();
            }
            else if (radioButton2.Checked)
            {
                res = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                double powNumber = Math.Pow(res, 2);
                textBox3.Text = powNumber.ToString();
            }
            else if (radioButton3.Checked)
            {
                string firstTextBox = textBox1.Text;
                string secondTextBox = textBox2.Text;
                string concat = firstTextBox + "!!!" + secondTextBox;
                string concatination = String.Concat(concat + "Good Job!");
                textBox3.Text = concatination.ToString();
            }
            else if (radioButton4.Checked)
            {
                res = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                textBox3.Text = res.ToString();
            }
        }
    }
}
