using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamaÇarpma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, toplam;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            toplam = a + b;
            label4.Text =toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c, d, carpma;
            c = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox3.Text);
            carpma = c * d;
            label5.Text = carpma.ToString();

        }
    }
}
