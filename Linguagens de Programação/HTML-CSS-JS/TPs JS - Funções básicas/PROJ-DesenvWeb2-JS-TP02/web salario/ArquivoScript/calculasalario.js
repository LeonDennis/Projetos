
function verificaSalario()
{
        var funcionario = document.getElementById("nomefunc").value;
        var salario = document.getElementById("salfunc").value;
        var acrescimo;
        
        if (salario <= 1500)
        {
                acrescimo = (20 * salario) / 100
                salario = (1 * salario) + (1 * acrescimo)
                document.write("O salário do funcionário ", funcionario , " somado com o acréscimo, é de: ", salario , "R$")
        }  
        else
        {
                if (salario > 1500 && salario < 2500)
                {
                        acrescimo = (10 * salario) / 100
                        salario = (1 * salario) + (1 * acrescimo)
                        document.write("O salário do funcionário ", funcionario , " somado com o acréscimo, é de: ", salario , "R$")
                }
                else
                {
                        acrescimo = (5 * salario) / 100
                        salario = (1 * salario) + (1 * acrescimo)
                        document.write("O salário do funcionário ", funcionario , " somado com o acréscimo, é de: ", salario , "R$")
                }
        }
}
        
//TP feito por Leon Dennis, RA 171353, da turma do período Noturno.