using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CadastroPessoas
{
    class PessoaDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;
        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Houve um erro ao se conectar ao banco de dados Access.");
            }

        }
        public static void desconecta()
        {
            conn.Close();
        }
        public static void inserePessoa(Pessoa person)
        {
            String aux = "insert into TabPessoa(codigo,nome,sexo,idade) values ('" + person.getCodigo() + "','" + person.getNome() + "','" + person.getSexo() + "','" + person.getIdade() + "')";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }
        public static void consultaPessoa(Pessoa person)
        {
            String aux = "select * from TabPessoa where codigo ='" + person.getCodigo() + "'";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                person.setNome(result.GetString(1));
                person.setSexo(result.GetString(2));
                person.setIdade(result.GetString(3));
            }
            else
                Erro.setMsg("Pessoa não cadastrada.");
        }
        public static void excluiPessoa(Pessoa person)
        {
            String aux = "delete from TabPessoa where codigo ='" + person.getCodigo() + "'";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }
        public static void alteraPessoa(Pessoa person)
        {
            String aux = "update TabPessoa set nome='" + person.getNome() + "', sexo='" + person.getSexo() + "', idade='" + person.getIdade() + "' where codigo ='" + person.getCodigo() + "'";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }
    }
}
