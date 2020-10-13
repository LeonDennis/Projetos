using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Livro
    {
        private string titulo, autor, editora, edicao, local;
        public void setTitulo(string titulo1) { titulo = titulo1; }
        public String getTitulo() { return titulo; }
        public void setAutor(string autor1) { autor = autor1; }
        public String getAutor() { return autor; }
        public void setEditora(string editora1) { editora = editora1; }
        public String getEditora() { return editora; }
        public void setEdicao(string edicao1) { edicao = edicao1; }
        public String getEdicao() { return edicao; }
        public void setLocal(string local1) { local = local1; }
        public String getLocal() { return local; }
    }
}
