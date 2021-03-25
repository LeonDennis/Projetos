using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDVendas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao se conectar ao banco de dados Access.");
            }

        }

        public Form1()
        {
            InitializeComponent();
            conecta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDVendasDataSet.TabVendedorVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVendedorVendasTableAdapter.Fill(this.bDVendasDataSet.TabVendedorVendas);
        }

        private void toolStripButtonInserir_Click(object sender, EventArgs e)
        {
            String aux = "insert into TabVendedorVendas(nome,mes,vendas) values ('" + nomeTextBox.Text + "','" + mesTextBox.Text + "','" + vendasTextBox.Text + "')";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            String aux = "delete from TabVendedorVendas where nome ='" + nomeTextBox.Text + "'";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVendasDataSet);
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
