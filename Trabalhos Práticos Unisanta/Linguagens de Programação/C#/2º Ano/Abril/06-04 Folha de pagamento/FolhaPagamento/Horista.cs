using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Horista
    {
        private String nome;
        private String qtdhoras;
        private String valorhora;

        public void setNome(String _nome) { nome = _nome; }
        public void setQtdhoras(String _qtdhoras) { qtdhoras = _qtdhoras; }
        public void setValorhora(String _valorhora) { valorhora = _valorhora; }
        public String getNome() { return nome; }
        public String getQtdhoras() { return qtdhoras; }
        public String getValorhora() { return valorhora; }
        public String calcSalarioBruto()
        {
            return (float.Parse(qtdhoras) * float.Parse(valorhora)).ToString("N2");
        }
        public String calcINSS()
        {
            float aux = float.Parse(calcSalarioBruto());
            float inss;

            if (aux < 1693.73) inss = aux * 0.08f;
            else if (aux < 2822.91) inss = aux * 0.09f;
            else if (aux < 5645.81) inss = aux * 0.11f;
            else inss = 5645.80f * 0.11f;

            return inss.ToString("N2");
        }
        public String calcIR()
        {
            float aux = float.Parse(calcSalarioBruto()) - float.Parse(calcINSS());
            float ir;

            if (aux < 1903.99) ir = 0;
            else if (aux < 2826.66) ir = aux * 0.075f - 142.80f;
            else if (aux < 3751.06) ir = aux * 0.15f - 354.80f;
            else if (aux < 4664.69) ir = aux * 0.225f - 636.13f;
            else ir = aux * 0.275f - 869.36f;

            return ir.ToString("N2");
        }
        public String calcSalarioLiquido(bool prof)
        {
            if (prof == true)
            {
                float salprof = (float.Parse(calcSalarioBruto()) - float.Parse(calcINSS()) - float.Parse(calcIR()));
                return (salprof + ((25 * salprof) / 100)).ToString("N2");
            }
            else
            {
                return (float.Parse(calcSalarioBruto()) - float.Parse(calcINSS()) - float.Parse(calcIR())).ToString("N2");
            }
        }
    }
}
