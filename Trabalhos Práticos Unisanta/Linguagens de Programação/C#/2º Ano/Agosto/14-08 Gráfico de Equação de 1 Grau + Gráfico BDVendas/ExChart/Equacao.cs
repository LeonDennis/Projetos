using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExChart
{
    class Equacao
    {
        public static sbyte getY(string var_x, string var_y, sbyte finicio)
        {
            //todamateria.com.br/funcao-afim/  |  f(0) = (2 * 0) + 3 = 3
            return (sbyte)((Convert.ToDouble(var_x) * finicio) + Convert.ToDouble(var_y));
        }
    }
}
