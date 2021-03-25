using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Veiculo
    {
        private String nome;
        private String fabricante;
        private String combustivel;
        private String ano;

        public void setNome (String nome_) {nome = nome_;}
        public void setFabricante(String fabricante_) { fabricante = fabricante_; }
        public void setCombustivel(String combustivel_) { combustivel = combustivel_; }
        public void setAno (String ano_) {ano = ano_;}

        public String getNome() { return nome;}
        public String getFabr() { return fabricante;}
        public String getComb() { return combustivel;}
        public String getAno() { return ano;}
    }
}
