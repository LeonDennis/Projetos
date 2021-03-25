using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class PessoaBLL
    {
        public static void conecta()
        {
            PessoaDAL.conecta();
        }

        public static void desconecta()
        {
            PessoaDAL.desconecta();
        }
        public static void validaCodigo(Pessoa person, char opcao)
        {
            Erro.setErro(false);
            if (person.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (opcao == 'C')
                PessoaDAL.consultaPessoa(person);
            else
                PessoaDAL.excluiPessoa(person);
        }

        public static void validaDados(Pessoa person, char opcao)
        {
            Erro.setErro(false);
            if (person.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório.");
                return;
            }
            if (person.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório.");
                return;
            }
            if (person.getIdade().Equals(""))
            {
                Erro.setMsg("A idade é de preenchimento obrigatório.");
                return;
            }
            if (person.getSexo().Equals(""))
            {
                Erro.setMsg("O sexo é de preenchimento obrigatório.");
                return;
            }

            try
            {
                int.Parse(person.getIdade());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor da idade deve ser numérico.");
                return;
            }


            if (int.Parse(person.getIdade()) <= 0)
            {
                Erro.setMsg("O valor da idade deve ser numérico e positivo.");
                return;
            }
            if (opcao == 'I')
                PessoaDAL.inserePessoa(person);
            else
                PessoaDAL.alteraPessoa(person);

        }
    }
}
