using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExChart
{
    class Validacao
    {
        public static bool validaDados(string var_x, string var_y, string f0inicio, string f0fim, bool invalido)
        {
            if (var_x.Equals("") || var_y.Equals(""))
            {
                MessageBox.Show("Os valores de f(x) são de preenchimento obrigatório.");
                return invalido;
            }

            try
            {
                int.Parse(var_x);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor do X deve ser numérico.");
                return invalido;
            }

            try
            {
                int.Parse(var_y);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor do Y deve ser numérico.");
                return invalido;
            }

            if (sbyte.Parse(var_x) < -100 || sbyte.Parse(var_x) > 100)
            {
                MessageBox.Show("O valor do X deve ser numérico e estar entre -100 e 100.");
                return invalido;
            }

            if (sbyte.Parse(var_y) < -100 || sbyte.Parse(var_y) > 100)
            {
                MessageBox.Show("O valor do Y deve ser numérico e estar entre -100 e 100.");
                return invalido;
            }

            if (f0inicio.Equals("") || f0fim.Equals(""))
            {
                MessageBox.Show("Os valores do início e do fim do gráfico são de preenchimento obrigatório. Valores padrões: 0 até 5.");
                return invalido;
            }

            try
            {
                int.Parse(f0inicio);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor do início do gráfico deve ser numérico.");
                return invalido;
            }

            try
            {
                int.Parse(f0fim);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor do final do gráfico deve ser numérico.");
                return invalido;
            }

            if (sbyte.Parse(f0inicio) < -100 || sbyte.Parse(f0inicio) > 100)
            {
                MessageBox.Show("O valor do início do gráfico deve ser numérico e estar entre -100 e 100.");
                return invalido;
            }

            if (sbyte.Parse(f0fim) < -100 || sbyte.Parse(f0fim) > 100)
            {
                MessageBox.Show("O valor do fim do gráfico deve ser numérico e estar entre -100 e 100.");
                return invalido;
            }

            if (sbyte.Parse(f0inicio) == sbyte.Parse(f0fim))
            {
                MessageBox.Show("Os valores do início e do fim do gráfico não podem ser iguais.");
                return invalido;
            }

            if (sbyte.Parse(f0inicio) > sbyte.Parse(f0fim))
            {
                MessageBox.Show("O valor do início do gráfico não pode ser maior que o fim do mesmo.");
                return invalido;
            }

            return invalido = false;
        }
    }
}
