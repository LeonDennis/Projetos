using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        CalculoGeteSet EqSegundoGrau = new CalculoGeteSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EqSegundoGrau.setA(textBoxA.Text);
            EqSegundoGrau.setB(textBoxB.Text);
            EqSegundoGrau.setC(textBoxC.Text);
            CalcBLL.validaDados(EqSegundoGrau);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                EqSegundoGrau.CalcDelta();
                if (float.Parse(EqSegundoGrau.CalcDelta()) == 0)
                {
                    MessageBox.Show("O delta da equação é zero, não há raízes possíveis.");
                }
                else
                {
                    if (float.Parse(EqSegundoGrau.CalcDelta()) < 0)
                    {
                        MessageBox.Show("O delta da equação é negativo, não há raízes reais. " + "\n" + "Mesmo assim, o resultado do delta calculado é: " + EqSegundoGrau.CalcDelta() + ".");
                    }
                    else
                    {
                        MessageBox.Show("Delta: " + EqSegundoGrau.CalcDelta() + "\n" + "x1: " + EqSegundoGrau.CalcX1() + "\n" + "x2: " + EqSegundoGrau.CalcX2());
                    }
                }                
            }
        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEdicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoMostrar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
