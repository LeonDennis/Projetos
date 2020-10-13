using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Nosso objeto de transposição

namespace WindowsFormsApplication1
{
    class Livro
    {
        private static String codigo;
        private static String titulo;
        private static String autor;
        private static String editora;
        private static String ano;

        public static void setCodigo(String _codigo) { codigo = _codigo; }
        public static void setTitulo(String _titulo) { titulo = _titulo; }
        public static void setAutor(String _autor) { autor = _autor; }
        public static void setEditora(String _editora) { editora = _editora; }
        public static void setAno(String _ano) { ano = _ano; }

        public static String getCodigo() { return codigo; }
        public static String getTitulo() { return titulo; }
        public static String getAutor() { return autor; }
        public static String getEditora() { return editora; }
        public static String getAno() { return ano; }
    }
}
