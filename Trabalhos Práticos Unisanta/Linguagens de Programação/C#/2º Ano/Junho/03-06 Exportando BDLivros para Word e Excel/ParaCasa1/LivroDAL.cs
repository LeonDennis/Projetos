using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ListaBDLivros
{
    class LivroDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
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
                Erro.setMsg("Banco da Dados não localizado - contacte o suporte.");
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }

      
        public static void populaDR()
        {
            String aux = "select * from TabLivro";

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
                Livro.setCodigo("" + dt.Rows[i].ItemArray[0]);
                Livro.setTitulo("" + dt.Rows[i].ItemArray[1]);
                Livro.setAutor("" + dt.Rows[i].ItemArray[2]);
                Livro.setEditora("" + dt.Rows[i].ItemArray[3]);
                Livro.setAno("" + dt.Rows[i].ItemArray[4]);
            }
        }
        public static DataTable GetDataTable()
        {
            return dt;
        }
    }
}
