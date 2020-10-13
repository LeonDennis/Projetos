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
            int media1, media2, media3, media4, mediafinal1;
            media1 = int.Parse(textBox1.Text);
            media2 = int.Parse(textBox2.Text);
            media3 = int.Parse(textBox3.Text);
            media4 = int.Parse(textBox4.Text);
            Aluno mediafinal = new Aluno { mediaa = media1, mediab = media2, mediac = media3, mediad = media4 };
            mediafinal1 = mediafinal.calculamedia;
            textBox6.Text = ""+mediafinal1;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
