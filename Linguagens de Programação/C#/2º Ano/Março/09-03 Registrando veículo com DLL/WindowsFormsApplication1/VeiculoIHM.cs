using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaErro;

namespace WindowsFormsApplication1
{
    public partial class VeiculoIHM : Form
    {
        Veiculo umveiculo = new Veiculo();
        public VeiculoIHM()
        {
            InitializeComponent();
            botaoMostrar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            umveiculo.setNome(textVeiculo.Text);
            umveiculo.setFabricante(textFabricante.Text);
            umveiculo.setCombustivel(comboComb.Text);
            umveiculo.setAno(maskedTextAno.Text);

            VeiculoBLL.validaDados(umveiculo);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textVeiculo.Text = umveiculo.getNome();
                textFabricante.Text = umveiculo.getFabr();
                comboComb.Text = umveiculo.getComb();
                maskedTextAno.Text = umveiculo.getAno();

                textVeiculo.Enabled = false;
                textFabricante.Enabled = false;
                comboComb.Enabled = false;
                maskedTextAno.Enabled = false;
                botaoMostrar.Enabled = true;

                MessageBox.Show("Os dados foram salvos com sucesso. ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do veículo: " + umveiculo.getNome() + "\n" + "Fabricante: " + umveiculo.getFabr() + "\n" +
                "Combustível: " + umveiculo.getComb() + "\n" + "Ano: " +  umveiculo.getAno());
        }

        private void botaoLimpa_Click(object sender, EventArgs e)
        {
            textVeiculo.Clear();
            textFabricante.Clear();
            maskedTextAno.Clear();
            comboComb.Text = "";

            textVeiculo.Enabled = true;
            textFabricante.Enabled = true;
            comboComb.Enabled = true;
            maskedTextAno.Enabled = true;
        }
    }
}
