using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaErro;

namespace WindowsFormsApplication1
{
    class VeiculoBLL
    {
        public static void validaDados(Veiculo _umveiculo)
        {
            Erro.setErro(false);
            if(_umveiculo.getNome().Length == 0)
            {
                Erro.setErro("Campo NOME  é de preenchimento obrigatório");
                return;
             }
            if (_umveiculo.getFabr().Length == 0)
            {
                Erro.setErro("Campo FABRICANTE  é de preenchimento obrigatório");
                return;
            }
            if (_umveiculo.getComb().Length == 0)
            {
                Erro.setErro("Campo COMBUSTÍVEL  é de preenchimento obrigatório");
                return;
            }
            if (_umveiculo.getAno().Length == 0)
            {
                Erro.setErro("Campo ANO  é de preenchimento obrigatório");
                return;
            }
        }
    }
}
