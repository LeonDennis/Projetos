using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CalcBLL
    {
        public static void validaDados(CalculoGeteSet ValidaGetSet)
        {
            Erro.setErro(false);
            if (ValidaGetSet.getA().Length == 0)
            {
                Erro.setErro("É obrigatório preencher o primeiro campo.");
                return;
            }
            else
                try
                {
                    float.Parse(ValidaGetSet.getA());
                }
                catch
                {
                    Erro.setErro("O primeiro campo deve ser numérico.");
                }
            {
                if (ValidaGetSet.getB().Length == 0)
                {
                    Erro.setErro("É obrigatório preencher o segundo campo.");
                    return;
                }
                else
                    try
                    {
                        float.Parse(ValidaGetSet.getB());
                    }
                    catch
                    {
                        Erro.setErro("O segundo campo deve ser numérico.");
                    }
                if (ValidaGetSet.getC().Length == 0)
                    {
                        Erro.setErro("É obrigatório preencher o terceiro campo.");
                        return;
                    }
                else
                    try
                    {
                        float.Parse(ValidaGetSet.getB());
                    }
                    catch
                    {
                        Erro.setErro("O terceiro campo deve ser numérico.");
                    }
            }
        }
    }
}
