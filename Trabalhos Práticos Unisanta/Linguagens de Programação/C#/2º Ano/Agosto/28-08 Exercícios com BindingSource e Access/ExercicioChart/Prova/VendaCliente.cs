using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class VendaCliente
    {
        private static String codigo;
        private static String cnpj;
        private static String data;
        private static String toneladas;
        private static String valor;

        public static void setCodigo(String _codigo) { codigo = _codigo; }
        public static void setCNPJ(String _cnpj) { cnpj = _cnpj; }
        public static void setData(String _data) { data = _data; }
        public static void setToneladas(String _toneladas) { toneladas = _toneladas; }
        public static void setvalor(String _valor) { valor = _valor; }
        public static String getCodigo() { return codigo; }
        public static String getCNPJ() { return cnpj; }
        public static String getData() { return data; }
        public static String getToneladas() { return toneladas; }
        public static String getValor() { return valor; }
    }
}
