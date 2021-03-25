using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i = 0;
        int a = 0;
        Icon newIcon = new Icon("fleur-de-lis.ico");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previsualizacao.ShowDialog();
        }

        private void relatorio_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            Font font = new Font("Lucida Console", 12);
            int linha = 10;
            while(i < 5)
            {
                ++i;
                e.Graphics.DrawString("UNISANTA    -             Universidade Santa Cecília", font, mCaneta, 10, linha);
                e.Graphics.DrawString("FACITESC    -             Faculdade de Ciências e Tecnologia de Santos", font, mCaneta, 10, linha + 30);
                e.Graphics.DrawString("Disciplina  -             Linguagem de Programação IV", font, mCaneta, 10, linha + 60);
                e.Graphics.DrawString("Professor   -             Maurício Neves Asenjo", font, mCaneta, 10, linha + 90);
                e.Graphics.DrawString("Página " + i, font, mCaneta, 700, 1120);
                e.Graphics.DrawIcon(newIcon, 30, 1110);

                for (int x = 0; x < 5; x++)
                {
                    if (a == 450) { a = 0; }
                    LivroBLL.getProximo();
                    e.Graphics.DrawString("Código: " + Livro.getCodigo() + "\nTítulo: " + Livro.getTitulo() +
                    "\nAutor: " + Livro.getAutor() + "\nEditora: " + Livro.getEditora() + "\nAno: " + Livro.getAno(), font, mCaneta, 10, linha + 120 + a);

                    a = a + 90;
                }
                
                linha += 150;
                if (i < 5)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LivroBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit();
            }
        }
    }
}
