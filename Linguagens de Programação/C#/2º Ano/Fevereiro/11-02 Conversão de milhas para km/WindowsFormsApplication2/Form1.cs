using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            double milhas, milhas1;
            double kilometros, kilometros1;
            milhas = double.Parse(textBox4.Text);
            kilometros = double.Parse(textBox4.Text);
            if (radioButton2.Checked)
            {
                ConverteMilhas valor = new ConverteMilhas { milhastemp = milhas };
                milhas1 = valor.milhaprakm;
                textBox1.Text = "" + milhas1;
            }
            else
            {
                ConverteKM valor1 = new ConverteKM { kmtemp = kilometros };
                kilometros1 = valor1.kmparamilha;
                textBox1.Text = "" + kilometros1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
