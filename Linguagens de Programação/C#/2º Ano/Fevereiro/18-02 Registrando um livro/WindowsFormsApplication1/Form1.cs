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
        Livro informacoesLivro = new Livro();
        public Form1()
        {
            InitializeComponent();
            botaoMostrar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAutor.Clear();
            textBoxTitulo.Clear();
            textBoxEditora.Clear();
            textBoxEdicao.Clear();
            textBoxLocal.Clear();

            textBoxTitulo.Enabled = true;
            textBoxAutor.Enabled = true;
            textBoxEditora.Enabled = true;
            textBoxEdicao.Enabled = true;
            textBoxLocal.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string mensagemsucesso = "Os dados do livro foram salvos com sucesso.";
           
            informacoesLivro.setTitulo(textBoxTitulo.Text);
            informacoesLivro.setAutor(textBoxAutor.Text);
            informacoesLivro.setEditora(textBoxEditora.Text);
            informacoesLivro.setEdicao(textBoxEdicao.Text);
            informacoesLivro.setLocal(textBoxLocal.Text);

            LivroBLL.validaDados(informacoesLivro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textBoxTitulo.Text = informacoesLivro.getTitulo();
                textBoxAutor.Text = informacoesLivro.getAutor();
                textBoxEditora.Text = informacoesLivro.getEditora();
                textBoxEdicao.Text = informacoesLivro.getEdicao();
                textBoxLocal.Text = informacoesLivro.getLocal();

                textBoxTitulo.Enabled = false;
                textBoxAutor.Enabled = false;
                textBoxEditora.Enabled = false;
                textBoxEdicao.Enabled = false;
                textBoxLocal.Enabled = false;
                botaoMostrar.Enabled = true;

                MessageBox.Show(mensagemsucesso);
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
            MessageBox.Show("Título: " + informacoesLivro.getTitulo() + "\n" + "Autor: " + informacoesLivro.getAutor() + "\n" +
                "Editora: " + informacoesLivro.getEditora() + "\n" + "Ano de edição: " + informacoesLivro.getEdicao() + "\n" +
                "Local: " + informacoesLivro.getLocal());
        }
    }
}
