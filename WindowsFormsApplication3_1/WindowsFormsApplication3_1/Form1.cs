using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int f(string num)
        {
            int min = 9;
            //string a = num.ToString();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '-')
                {
                    string c = num[i].ToString();
                    int n = Convert.ToInt32(c);
                    if (n < min) { min = n; }
                }
            }
            return min;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           


                try
                {
                    string a = textBox1.Text;
                    string b = textBox2.Text;
                    int z = f(a) + f(b);
                    textBox3.Text = "z = " + z.ToString();
                }
                catch { MessageBox.Show("Некорректный ввод данных"); }
            }

      
    }
    }


