using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

namespace ListaBDLivros
{
    public partial class CadLivrosUIL : Form
    {
        string path;
        public CadLivrosUIL()
        {
            InitializeComponent();
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
            LivroBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                System.Windows.Forms.Application.Exit();
            }
        }

        private void CadLivrosUIL_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroBLL.desconecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LivroBLL.getProximo();
            while (!Erro.getErro())
            {
                listBox1.Items.Add("Titulo = " + Livro.getTitulo() + " escrito por " + Livro.getAutor());
                LivroBLL.getProximo();
            }

        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(getPath(1))) //cria a pasta /pasta_temporaria/, em C. para utilizar, é necessário o "using System.IO;"
            {
                DirectoryInfo criapasta = Directory.CreateDirectory(getPath(1));
            }

            if (File.Exists(getPath(2))) //checa se o arquivo já existe. para utilizar, é necessário o "using System.IO;"
            {
                MessageBox.Show("A listagem em Docx/PDF do banco de dados BDLivros já foi gerada na pasta 'C:/pasta_temporaria/'.");
                return;
            }

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();
            Selection texto = word.Selection;

            doc.Activate();

            LivroBLL.getProximo();
            while (!Erro.getErro())
            {
                texto.TypeText("Código: " + Livro.getCodigo() + "\nTítulo: " + Livro.getTitulo() +
                "\nAutor: " + Livro.getAutor() + "\nEditora: " + Livro.getEditora() + "\nAno: " + Livro.getAno());

                texto.TypeParagraph();
                texto.TypeText("---------------------------\n");
                LivroBLL.getProximo();
            }

            doc.SaveAs(getPath(2));
            doc.SaveAs(getPath(3), WdSaveFormat.wdFormatPDF);

            word.Documents.Close();
            word.Quit();

            MessageBox.Show("Os dados do banco BDLivros foram salvos em .docx e .pdf, na pasta 'C:/pasta_temporaria/'.");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(getPath(1))) //cria a pasta /pasta_temporaria/, em C. para utilizar, é necessário o "using System.IO;"
            {
                DirectoryInfo criapasta = Directory.CreateDirectory(getPath(1));
            }

            if (File.Exists(getPath(4))) //checa se o arquivo já existe. para utilizar, é necessário o "using System.IO;"
            {
                MessageBox.Show("A listagem em Excel do banco de dados BDLivros já foi gerada na pasta 'C:/pasta_temporaria/'.");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Worksheet ws = excel.ActiveSheet;

            for (int i = 0; i < LivroDAL.GetDataTable().Columns.Count; i++)
            {
                ws.Cells[1, (i + 1)] = LivroDAL.GetDataTable().Columns[i].ColumnName;
                for (int j = 0; j < LivroDAL.GetDataTable().Rows.Count; j++)
                {
                    ws.Cells[(j + 2), (i + 1)] = LivroDAL.GetDataTable().Rows[j][i];
                }
            }

            ws.SaveAs(getPath(4));

            excel.Quit();

            MessageBox.Show("Os dados do banco de dados BDLivros foram salvos em .xlsx, na pasta 'C:/pasta_temporaria/'.");
        }

        private void buttonDelPastas_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(getPath(1)))
            {
                MessageBox.Show("Nenhuma pasta foi gerada por este programa.");
                return;
            }
            else
            {
                File.Delete(getPath(2));
                File.Delete(getPath(3));
                File.Delete(getPath(4));
                Directory.Delete(getPath(1));
                MessageBox.Show("A pasta e os arquivos foram deletados com sucesso.");
            }
        }

        private string getPath(int opcao)
        {
            if (opcao == 1)
            {
                return path = @"C:\pasta_temporaria\";
            }
            if (opcao == 2)
            {
                return path = @"C:\pasta_temporaria\tp.docx";
            }
            if (opcao == 3)
            {
                return path = @"C:\pasta_temporaria\tp.pdf";
            }
            if (opcao == 4)
            {
                return path = @"C:\pasta_temporaria\tp.xlsx";
            }

            return Erro.getMsg();
        }
    }
}
