function validacao()
{
        var aviso = alert("TP feito por Leon Dennis, RA 171353, da turma do período Noturno.")
        var identificacao = prompt("Identifique-se, professor.", "Medina");
        if (identificacao != "Medina")
        {
                document.write("Nome incorreto.");
        }
        else
        {
                var senha = prompt("Digite sua senha, professor.", "123456");
                if (senha != "123456")
                {
                        document.write("Senha incorreta.");
                }
        }
}
function calculanota()
{
        var nomedoaluno = document.getElementById("nomealuno").value;
        var notadoaluno1 = document.getElementById("p1aluno").value;
        var notadoaluno2 = document.getElementById("p2aluno").value;
        var mediafinal =  (notadoaluno1 * 4 + notadoaluno2 * 6) / 10;
        
        if (mediafinal != -1)
        {
                if (mediafinal > 8 && mediafinal < 11)
                {
                        document.write("O aluno " , nomedoaluno , " tem conceito A, e está aprovado, com média " , mediafinal);
                }
                else
                if (mediafinal > 6 && mediafinal < 10)
                {
                        document.write("O aluno " , nomedoaluno , " tem conceito B, e está aprovado, com média " , mediafinal);
                }
                else
                if (mediafinal > 2 && mediafinal < 8)
                {
                        document.write("O aluno " , nomedoaluno , " tem conceito C, e está de exame, com média " ,mediafinal);
                }
                else
                if (mediafinal = 0 || mediafinal < 3)
                {
                        document.write("O aluno " , nomedoaluno , " tem conceito D, e está reprovado na tal matéria.");
                }
                else
                document.write("Os valores dados não correspondem a média entre 0 e 10.");
        }       
        if (mediafinal > 10)
        {
                document.write("Os valores dados não correspondem a média entre 0 e 10.");
        }
}
        
//TP feito por Leon Dennis, RA 171353, da turma do período Noturno.