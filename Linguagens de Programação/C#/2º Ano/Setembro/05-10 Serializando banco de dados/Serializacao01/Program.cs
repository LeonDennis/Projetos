using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Data.OleDb;
using System.Data;
using Newtonsoft.Json;

namespace Serializacao01
{
    class Program
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbDataAdapter adaptador;
        private static DataTable dt = new DataTable { TableName = "BDLivros" };
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
        public static void populaDR()
        {
            String aux = "select * from TabLivro";

            adaptador = new OleDbDataAdapter(aux, conn);
            adaptador.Fill(dt);
            adaptador.Dispose();
        }

        static void Main(string[] args)
        {
            int opcao = 0;
            string opcao1;
            do
            {
                Console.WriteLine("Serializar o banco de dados BDLivros em: ");
                Console.WriteLine("1 - XML");
                Console.WriteLine("2 - JSON");
                Console.WriteLine("3 - Console c/ Infile e Outfile");
                Console.WriteLine("4 - SAIR");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        populaDR();
                        TextWriter arquivo = new StreamWriter("teste1.xml");
                        XmlSerializer obj = new XmlSerializer(dt.GetType());
                        obj.Serialize(arquivo, dt);
                        Console.WriteLine("XML 'teste1.xml' gerado com sucesso. ");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        populaDR();
                        File.WriteAllText("teste2.json", JsonConvert.SerializeObject(dt));
                        Console.WriteLine("JSON 'teste2.json' Gerado com sucesso. ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite o nome do arquivo (e a extensão do mesmo) que se encontra na pasta debug deste projeto:");
                        opcao1 = Console.ReadLine();
                        if (!File.Exists(opcao1)) { Console.WriteLine("Este arquivo não existe."); break; }
                        infileOutfile(opcao1);
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 4);
        }
        public static void infileOutfile(string opcao1)
        {
            FileStream infile;
            int tam;
            char x;

            infile = new System.IO.FileStream("" + opcao1,
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.Read);

            tam = (int)infile.Length;
            for (int i = 0; i < tam; ++i)
            {
                x = (char)infile.ReadByte();
                Console.Write(x);
                if (i % 10 == 0) { Console.WriteLine(); }
            }
            infile.Close();
        }
    }
}