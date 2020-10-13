var aviso = alert("Feito por Leon Dennis, RA 171353, Noturno.")
const calcular =() =>{
    let err
try 
{
   var nome = document.getElementById("nome").value
   var endereco = document.getElementById("endereco").value
   var cidade = document.getElementById("cidade").value
   var cep = document.getElementById("CEP").value
   var uf = document.getElementById("UF").value
   var tel = document.getElementById("tel").value
   var sexo = document.getElementById("sex").value

   if(nome.length == 0)
   {
       throw "É obrigatório preencher o nome."
   }
   else
   {
        if(endereco.length == 0)
        {
            throw "É obrigatório preencher seu endereço."
        }
        else
        {
            if(cidade.length == 0)
            {
                throw "É obrigatório preencher sua cidade."
            }
            else
            {
                if(cep.length == 0)
                {
                    throw "É obrigatório preencher seu CEP."
                }
                else
                {
                    if (isNaN(cep) == true)
                    {
                        throw "O valor do CEP deve ser numérico."
                    }
                    else
                    {
                        if(uf.length == 0)
                        {
                            throw "É obrigatório preencher seu UF."
                        }
                        else
                        {
                            if (isNaN(uf) == false)
                            {
                                throw "O campo UF não deve conter números."
                            }
                            else
                            {
                                if(tel.length == 0)
                                {
                                    throw "É obrigatório preencher seu telefone."
                                }
                                else
                                {
                                    if (isNaN(cep) == true)
                                    {
                                        throw "O campo telefone deve ser numérico."
                                    }
                                    else
                                    {
                                        if(sexo.length == 0)
                                        {
                                            throw "É obrigatório preencher seu sexo."
                                        }
                                        else
                                        {
                                            if (isNaN(sexo) == false)
                                            {
                                                throw "O campo sexo não deve conter números."
                                            }
                                            else
                                            {
                                                if (sexo != "Masculino" && sexo != "masculino" && sexo != "Feminino" && sexo != "feminino")
                                                {
                                                    throw "Sexo desconhecido. (Apenas masculino e feminino)"
                                                }
                                                else
                                                {
                                                    var x = new Boolean(true);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
   }
}
catch (e)
    {
        alert(e.toString())
        err = e.toString()
        console.log(err)
    } 
    finally
    {
        if (x == true)
        {
            window.alert("Dados salvos com sucesso.");
        }
        else
        {
            alert("A conta não pode ser realizada por um motivo desconhecido. Reinicie a página.");
        }
    }
}
function limpar()
{
    dolar = 0;
    dia = 0;
    real = 0;
    location.reload();
}
function sair()
{
    close();
}

