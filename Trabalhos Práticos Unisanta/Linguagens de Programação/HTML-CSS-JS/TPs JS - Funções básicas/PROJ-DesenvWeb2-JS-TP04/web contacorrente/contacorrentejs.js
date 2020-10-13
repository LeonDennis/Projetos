let SaldoTotal = 100.00

const CriarCC = () => {

    let err

    try {

        let nome = document.getElementById("nome").value
        let rg = document.getElementById("rg").value
        let end = document.getElementById("end").value
        let cc = document.getElementById("cc").value

        if(nome.length == 0) {
            throw "O Nome não pode ser vazio."
        }
        if(rg.length == 0) {
            throw "O RG não pode ser vazio."
        }
        if(end.length == 0) {
            throw "O Endereço não pode ser vazio."
        }
        if(cc.length == 0) {
            throw "A Conta Corrente não pode ser vazia."
        }

        document.getElementById("criar-conta").style.display = "none"
        document.getElementById("deposito").style.display = "inherit"
        throw "Sucesso"
        

    }
    catch(e) {
        err = e.toString();
    }
    finally {
        console.log(err)
        if(err != undefined ){
            document.getElementById("msg").innerHTML = err}
    }

}

const depositar = () => {

    let err

    try {
        let ValorDeposito = document.getElementById("valorDeposito").value

        if(ValorDeposito.length == 0) {
            throw "É obrigatório digitar o valor do depósito."
        }

        if(ValorDeposito <= 0) {
            throw "O valor do depósito deve ser somente positivo."
        }

        SaldoTotal += parseFloat(ValorDeposito)
        console.log(SaldoTotal)
        err = "Saldo atual: R$" + SaldoTotal.toString()
    }
    catch(e) {
        err = e.toString();
    }
    finally {
        console.log(err)
        if(err != undefined ){
            document.getElementById("msg2").innerHTML = err}
    }
}

const next = () => {
    document.getElementById("deposito").style.display = "none"
    document.getElementById("debito").style.display = "inherit"
}

const prev = () => {
    document.getElementById("deposito").style.display = "inherit"
    document.getElementById("debito").style.display = "none"
}

const finish = () => {
    document.getElementById("debito").style.display = "none"
    document.getElementById("saldo").style.display = "inherit"

    document.getElementById("saldoValue").innerHTML = "R$" + SaldoTotal.toString()
}

const debitar = () => {
    let err

    try {
        let ValorDebito = document.getElementById("ValorDebito").value

        if(ValorDebito.length == 0) {
            throw "É obrigatório digitar o valor do débito."
        }

        if(ValorDebito > SaldoTotal) {
            throw "Você não possui essa quantia disponível!"
        }

        SaldoTotal -= parseFloat(ValorDebito)
        console.log(SaldoTotal)
        err = "Saldo atual: R$" + SaldoTotal.toString()
    }
    catch(e) {
        err = e.toString();
    }
    finally {
        console.log(err)
        if(err != undefined ){
            document.getElementById("msg3").innerHTML = err}
    }
}


// Leon Dennis, RA 171353, Noturno.