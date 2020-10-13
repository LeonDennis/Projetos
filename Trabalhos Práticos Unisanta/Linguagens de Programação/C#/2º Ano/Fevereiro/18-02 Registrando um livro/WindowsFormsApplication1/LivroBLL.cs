using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LivroBLL
    {
        public static void validaDados(Livro informacoesLivro)
        {
            Erro.setErro(false);
            if (informacoesLivro.getTitulo().Length == 0)
            {
                Erro.setErro("É obrigatório preencher o campo do Título.");
                return;
            }
            else
            {
                if (informacoesLivro.getAutor().Length == 0)
                {
                    Erro.setErro("É obrigatório preencher o campo do Autor.");
                    return;
                }
                else
                {
                    if (informacoesLivro.getEditora().Length == 0)
                    {
                        Erro.setErro("É obrigatório preencher o campo da Editora.");
                        return;
                    }
                    else
                    {
                        if (informacoesLivro.getEdicao().Length < 0)
                        {
                            Erro.setErro("O Ano de Edição do Livro deve ser um número inteiro e positivo.");
                            return;
                        }
                        else
                        {
                            if (informacoesLivro.getEdicao().Length == 0)
                            {
                                Erro.setErro("É obrigatório preencher o campo da Edição.");
                                return;
                            }
                            else
                            {
                                try
                                {
                                    float.Parse(informacoesLivro.getEdicao());
                                }
                                catch
                                {
                                    Erro.setErro("O campo Edição deve ser numérico.");
                                    return;
                                }
                                if (informacoesLivro.getLocal().Length == 0)
                                {
                                    Erro.setErro("É obrigatório preencher o campo do Local.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
