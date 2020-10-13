using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Todos os campos são de preenchimento obrigatorio
 * Ano de edição deverá ser numérico e positivo
*/

namespace ListaBDLivros
{
    class LivroBLL
    {
        public static void conecta()
        {
            LivroDAL.conecta();
            if (!Erro.getErro())
            {
                LivroDAL.populaDR();
            }
        }

        public static void desconecta()
        {
            LivroDAL.desconecta();
        }

        public static void getProximo()
        {
            LivroDAL.getProximo();
        }

    }
}

