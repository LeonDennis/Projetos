using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        string sexo;
        Pessoa person = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            maskedTextBoxIdade.Text = "";
            textBoxSexoOutros.Text = "";
            
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            person.setCodigo(textBoxCodigo.Text);
            person.setNome(textBoxNome.Text);
            if (radioButtonMasculino.Checked == true)
            {
                sexo = "M";
            }
            else
            {
                if (radioButtonFeminino.Checked == true)
                {
                    sexo = "F";
                }
                else
                {
                    sexo = textBoxSexoOutros.Text;
                }
            }
            person.setSexo(sexo);
            person.setIdade(maskedTextBoxIdade.Text);

            PessoaBLL.validaDados(person, 'I');
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Os dados foram salvos com sucesso.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PessoaBLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PessoaBLL.desconecta();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            person.setCodigo(textBoxCodigo.Text);

            PessoaBLL.validaCodigo(person, 'C');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                textBoxCodigo.Text = person.getCodigo();
                textBoxNome.Text = person.getNome();
                if (person.getSexo() == "M")
                {
                    radioButtonMasculino.Checked = Enabled;
                }
                else
                {
                    if (person.getSexo() == "F")
                    {
                        radioButtonFeminino.Checked = Enabled;
                    }
                    else
                    {
                        radioButtonOutros.Checked = Enabled;
                        textBoxSexoOutros.Text = person.getSexo();
                    }
                }
                maskedTextBoxIdade.Text = person.getIdade();
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            person.setCodigo(textBoxCodigo.Text);

            PessoaBLL.validaCodigo(person, 'E');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                MessageBox.Show("Os dados da pessoa foram excluídos com sucesso.");
                textBoxCodigo.Clear();
                textBoxNome.Clear();
                maskedTextBoxIdade.Clear();
                textBoxSexoOutros.Clear();
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            person.setCodigo(textBoxCodigo.Text);
            person.setNome(textBoxNome.Text);
            if (radioButtonMasculino.Checked == true)
            {
                sexo = "M";
            }
            else
            {
                if (radioButtonFeminino.Checked == true)
                {
                    sexo = "F";
                }
                else
                {
                    sexo = textBoxSexoOutros.Text;
                }
            }
            person.setSexo(sexo);
            person.setIdade(maskedTextBoxIdade.Text);

            PessoaBLL.validaDados(person, 'A');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Os dados foram alterados com sucesso.");
        }
    }
}
