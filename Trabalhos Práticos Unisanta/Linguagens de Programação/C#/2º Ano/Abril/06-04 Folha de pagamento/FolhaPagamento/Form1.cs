using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Form1 : Form
    {
        Horista umhorista = new Horista();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButtonProf.Checked == false && radioButtonFunc.Checked == false)
            {
                MessageBox.Show("É obrigatório selecionar o botão funcionário ou o botão horista.");
            }
            else
            {
                umhorista.setNome(textBox1.Text);
                umhorista.setQtdhoras(textBox2.Text);
                umhorista.setValorhora(textBox3.Text);
                HoristaBLL.validaDados(umhorista);
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMens());
                }
                else
                {
                    if (radioButtonProf.Checked == true)
                    {
                        bool prof = true;
                        MessageBox.Show("Salário Bruto: " + umhorista.calcSalarioBruto() +
                                        "\nINSS: " + umhorista.calcINSS() +
                                        "\nIR: " + umhorista.calcIR() +
                                        "\nSalário Líquido: " + umhorista.calcSalarioLiquido(prof = false) +
                                        " | Com acréscimo de 25%: " + umhorista.calcSalarioLiquido(prof = true) +
                                        "\nTodos os professores recebem um acréscimo de 25% no salário para levar em conta o tempo de preparação das aulas.");
                    }
                    else
                    {
                        bool prof = false;
                        MessageBox.Show("Salário Bruto: " + umhorista.calcSalarioBruto() +
                                        "\nINSS: " + umhorista.calcINSS() +
                                        "\nIR: " + umhorista.calcIR() +
                                        "\nSalário Líquido: " + umhorista.calcSalarioLiquido(prof));
                    }
                }
            }
        }
    }
}
