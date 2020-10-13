using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico02
{
    public partial class Form1 : Form
    {
        int faturamento = 0;
        Button[] b = new Button[200];
        public Form1()
        {
            InitializeComponent();
        }
        private void metodoGenerico(object sender, EventArgs e)
        {
            Button aux = (Button)sender;
            if (aux.BackColor == Color.Red)
            {
                aux.BackColor = Color.Green;
            }
            else
            {
                aux.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int d = 0; //D = contador das linhas(fileiras)
            int f = 0; //F = altera a posição das colunas, gera botões de 10 em 10
            int colunas = 1;
            char fileiras = 'A';
            for (int i = 0; i < 200; ++i)
            {
                b[i] = new Button();
                b[i].BackColor = Color.Green;
                b[i].ForeColor = Color.FromArgb(255, 255, 255);
                b[i].Name = (fileiras + "-" + colunas);
                b[i].Text = (fileiras + "-" + colunas);
                b[i].Location = new Point(90 * (d + 1), 9 + f);
                Controls.Add(b[i]);
                d++;
                colunas++;
                if (d == 10) //quantidade de botões por linha(fileira)
                {
                    d = 0;
                    f = f + 33;
                }
                if (colunas == 21)
                {
                    colunas = 1;
                    ++fileiras;
                }
                b[i].Click += new System.EventHandler(this.metodoGenerico);
            }
        }
        private void buttonFaturamento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; ++i)
            {
                if (b[i].BackColor == Color.Red)
                {
                    faturamento = faturamento + 20;
                }
                b[i].Enabled = false;
            }
            MessageBox.Show("Faturamento: " + faturamento + "R$.");
            buttonFaturamento.Enabled = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            label3.Text = faturamento.ToString();
            faturamento = 0;
            for (int i = 0; i < 200; ++i)
            {
                if (b[i].BackColor == Color.Red)
                {
                    b[i].BackColor = Color.Green;
                }
                b[i].Enabled = true;
                buttonFaturamento.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
