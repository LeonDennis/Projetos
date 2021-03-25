using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace ExChart
{
    class BDVendasDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDVendas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbDataAdapter adaptador;
        private static DataTable dt = new DataTable();
        private static int i = -1;
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
        public static void desconecta()
        {
            conn.Close();
        }
        public static void populaDR()
        {
            String aux = "select * from TabVendasAno";

            adaptador = new OleDbDataAdapter(aux, conn);
            adaptador.Fill(dt);
            adaptador.Dispose();
        }
        public static void getProximo()
        {
            Erro.setErro(false);
            ++i;
            if (i >= dt.Rows.Count)
                Erro.setErro(true);
            else
            {
                BDVendasBLL.setBDX((int)dt.Rows[i].ItemArray[0]);
                BDVendasBLL.setBDY((int)dt.Rows[i].ItemArray[1]);
            }
        }
    }
}
