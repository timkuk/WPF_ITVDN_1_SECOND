using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson33HomeWork33_Task1
{
    public partial class Form1 : Form
    {
        Assembly assembly = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void OPEN_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                try
                {
                    assembly = Assembly.LoadFrom(path);
                    ReflectionText.Text = assembly.FullName;
                    Type[] types = assembly.GetTypes();
                    foreach (var tip in types)
                    {
                        ReflectionText.Text = "Тип " + tip + Environment.NewLine;

                        var methods = tip.GetMethods();
                        if (methods != null)
                        {
                            foreach (var method in methods)
                            {
                                string methStr = "Метод:" + method.Name + "\n";
                                var methodBody = method.GetMethodBody();
                                if (methodBody != null)
                                {
                                    var byteArray = methodBody.GetILAsByteArray();

                                    foreach (var b in byteArray)
                                    {
                                        methStr += b + ":";
                                    }
                                }
                                ReflectionText.Text += methStr + Environment.NewLine;
                            }
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
