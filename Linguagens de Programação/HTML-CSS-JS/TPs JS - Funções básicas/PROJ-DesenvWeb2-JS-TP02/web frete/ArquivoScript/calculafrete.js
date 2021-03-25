
function verificaFrete()
{
        var varfrete = document.getElementById("valorfrete").value;
        
        if (varfrete >= 100)
        {
                document.write("O frete da sua compra é grátis.");
        }
        else
        {
                        varfrete = ((10 * varfrete) / 100)
                        document.write("O valor do frete da sua compra é de: " , varfrete , "R$.");
        }   
}
        
//TP feito por Leon Dennis, RA 171353, da turma do período Noturno.