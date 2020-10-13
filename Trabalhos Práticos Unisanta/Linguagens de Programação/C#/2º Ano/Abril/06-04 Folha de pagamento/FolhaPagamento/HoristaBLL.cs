using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class HoristaBLL
    {
        public static void validaDados(Horista umhorista)
        {
            Erro.setErro(false);
            if (umhorista.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório...");
                return;
            }

            if (umhorista.getQtdhoras().Length == 0)
            {
                Erro.setErro("O campo QTD HORAS é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    if (float.Parse(umhorista.getQtdhoras()) <= 0)
                    {
                        Erro.setErro("O campo QTD HORAS deve ser maior que zero...");
                        return;
                    }
                }
                catch
                {
                    Erro.setErro("O campo QTD HORAS deve ser numérico...");
                    return;
                }
            }

            if (umhorista.getValorhora().Length == 0)
            {
                Erro.setErro("O campo VALOR/HORA é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    if (float.Parse(umhorista.getValorhora()) <= 0)
                    {
                        Erro.setErro("O campo VALOR/HORA deve ser maior que zero...");
                        return;
                    }
                }
                catch
                {
                    Erro.setErro("O campo VALOR/HORA deve ser numérico...");
                    return;
                }
            }

        }
    }
}
