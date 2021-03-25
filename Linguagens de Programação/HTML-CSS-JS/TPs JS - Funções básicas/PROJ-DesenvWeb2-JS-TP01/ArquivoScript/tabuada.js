for (var i = 0; i < 10; i++) {
    document.write("<p>Tabuada do " + i + "</p>");
for (var j = 0; j < 10; j++) {
    document.write(i + " x " + j + " = " + (i * j) + "<br>");
    }
}

function contatabuada()
{
var numerodigitado = document.getElementById("numerotabuada").value;

    document.write("<p>Tabuada do " + numerodigitado + "</p>");

    for (var j = 0; j < 10; j++) {
        document.write(numerodigitado + " x " + j + " = " + (numerodigitado * j) + "<br>");
        }
}
//TP feito por Leon Dennis, RA 171353, da turma do período Noturno.