using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDFarinhaDataSet.TabVendasCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVendasClienteTableAdapter.Fill(this.bDFarinhaDataSet.TabVendasCliente);
            BLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente.setCNPJ(textBox1.Text);
            BLL.validaCNPJ(textBox1.Text);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());

            else
            {
                textBox2.Text = Cliente.getNome();
                tabVendasClienteBindingSource.Filter = "Cnpj = " + textBox1.Text;
                bindingSource1.Filter = "Cnpj = " + textBox1.Text;
                textBox3.Text = "Total: " + calculoSoma(1) + " tons.";
                textBox4.Text = "Total: " + calculoSoma(0) + " R$.";
            }
        }
        private string calculoSoma(int opcao)
        {
            if (opcao == 1)
            {
                DataTable table;
                table = bDFarinhaDataSet.Tables["TabVendasCliente"];
                var result = table.AsEnumerable()
                                   .Where(r => r.Field<string>("Cnpj") == "" + textBox1.Text)
                                   .Sum(x => Convert.ToInt32(x["toneladas"])); //retorna os valores da tabela toneladas onde cnpj = dado pelo usuário, LINQ to datatable

                return Convert.ToString(result);
            }
            else
            {
                DataTable table;
                table = bDFarinhaDataSet.Tables["TabVendasCliente"];
                var result = table.AsEnumerable()
                                   .Where(r => r.Field<string>("Cnpj") == "" + textBox1.Text)
                                   .Sum(x => Convert.ToDouble(x["valor"]));

                return Convert.ToString(result);
            }

            //var result = table.AsEnumerable().Sum(x => Convert.ToInt32(x["toneladas"])); - retorna todos os valores da coluna toneladas
            //se os dados do banco não fossem string, este código poderia ser usado:

            // Presumes a DataTable named "Orders" that has a column named "Total."
            //DataTable table;
            //table = dataSet.Tables["Orders"];

            // Declare an object variable.
            //object sumObject;
            //sumObject = table.Compute("Sum(Total)", "EmpID = 5");
        }
    }
}
  
