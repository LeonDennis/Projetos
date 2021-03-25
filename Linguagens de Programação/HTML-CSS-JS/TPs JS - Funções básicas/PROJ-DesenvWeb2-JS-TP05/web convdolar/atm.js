var aviso = alert("Feito por Leon Dennis, RA 171353, Noturno.")
const calcular =() =>{
    let err
try 
{
   var dolar = document.getElementById("dolar").value
   var dia = document.getElementById("dia").value
   if(dolar.length == 0)
   {
       throw "O valor do dólar é obrigatório."
   }
   else
   {
    if (isNaN(dolar) == true)
    {
        throw "O valor do dólar deve ser numérico."
    }
    else
    {
        if(dia.length == 0)
        {
            throw "A cotação do dia é obrigatória."
        } 
        else
        {
            if (isNaN(dia) == true)
            {
                throw "O valor da cotação do dia deve ser numérico."
            }
            else
            {
                {
                    dolar = dolar * 1;
                    dia = dia * 1;
                    var x = new Boolean(true);
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
            var reais;
            reais = (dolar * dia) * 1;
            window.alert("O valor convertido de dólares para reais é de: " + reais + "R$");
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

