using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ParaCasa1
{
    class LivroDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        //private static OleDbDataReader result;
        private static OleDbDataAdapter adaptador;
        private static DataTable dt = new DataTable();
        private static int i=-1;
        private static int ultimodado;
        private static int primeirodado;
        private static string mensagemerro = "Não há mais dados para serem mostrados.";
        private static Livro umlivro = new Livro();
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
            primeirodado = 0;
            ultimodado = dt.Rows.Count - 1;
            adaptador.Dispose();
        }

        public static void setLivro()
        {
            umlivro.setCodigo(dt.Rows[i].ItemArray[0].ToString());
            umlivro.setTitulo(dt.Rows[i].ItemArray[1].ToString());
            umlivro.setAutor(dt.Rows[i].ItemArray[2].ToString());
            umlivro.setEditora(dt.Rows[i].ItemArray[3].ToString());
            umlivro.setAno(dt.Rows[i].ItemArray[4].ToString());
        }

        public static Livro getProximo()
        {
            ++i;
            if (i > ultimodado)
            {
                //Erro.setMsg("Não há mais dados para serem mostrados.");
                i--;
                MessageBox.Show(mensagemerro);
                return umlivro;
            }
            setLivro();
            return umlivro;
        }

        public static Livro getAnterior()
        {
            --i;
            if (i < primeirodado)
            {
                //Erro.setMsg("Não há mais dados para serem mostrados.");
                i++;
                MessageBox.Show(mensagemerro);
                return umlivro;
            }
            setLivro();
            return umlivro;
        }

        public static Livro getPrimeiro()
        {
            i=0;
            setLivro();
            return umlivro;
        }

        public static Livro getUltimo()
        {
            i = dt.Rows.Count - 1;
            setLivro();
            return umlivro;
        }
    }
}
