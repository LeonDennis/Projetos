function mediap1()
{
    var quantidade = parseFloat(document.getElementById("quantidade").value);
    if(quantidade > 15)
    {
        alert("O número máximo de alunos é 15.");
    }
    else
    {
        var notas = 0;
        cont = 0;
        for (i = 0; i < quantidade; i++)
        {
            cont++;
            notas += parseInt(prompt("Digite a nota da p1 do aluno " + cont + ": "));
        }
        media = notas / quantidade;
        document.getElementById('media').innerHTML = "Media: " + media;
        confirm("TP feito por Leon Dennis, RA 171353, da turma do período Noturno.");
    }
    
}