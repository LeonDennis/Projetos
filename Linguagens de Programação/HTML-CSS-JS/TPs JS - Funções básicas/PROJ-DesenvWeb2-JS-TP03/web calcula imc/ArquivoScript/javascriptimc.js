
function calculaimc()
{
var aviso = alert("TP feito por Leon Dennis, RA 171353, da turma do período Noturno.")
var varpeso = document.getElementById("peso").value;
var varaltura = document.getElementById("altura").value;
var imc = (varpeso / (varaltura * varaltura));

if (document.getElementById('Mas').checked)
{
        if (imc < 20)
        {
                document.write("Você é uma pessoa do sexo masculino, e está abaixo do peso ideal.");
        }
        else
        if (imc <= 20 && imc < 25)
        {
                document.write("Você é uma pessoa do sexo masculino, e está no peso ideal.");
        }
        else
        if (imc >= 25)
        {
                document.write("Você é uma pessoa do sexo masculino, e está acima do peso ideal.");
        }
}
else

if (document.getElementById('Fem').checked)
{
        if (imc < 19)
        {
                document.write("Você é uma pessoa do sexo feminino, e está abaixo do peso ideal.");
        }
        else
        if (imc <= 19 && imc < 24)
        {
                document.write("Você é uma pessoa do sexo feminino, e está no peso ideal.");
        }
        else
        if (imc >= 24)
        {
                document.write("Você é uma pessoa do sexo feminino, e está acima do peso ideal.");
        }
}

}
//TP feito por Leon Dennis, RA 171353, da turma do período Noturno.