let saldoTotal = 100.00

const criarConta = () => {

    let err

    try {

        let nome = document.getElementById("nome").value
        let rg = document.getElementById("rg").value
        let end = document.getElementById("end").value
        let cc = document.getElementById("cc").value

        if(nome.length == 0) {
            throw "Nome não pode ser vazio!"
        }
        if(rg.length == 0) {
            throw "RG não pode ser vazio!"
        }
        if(end.length == 0) {
            throw "Endereço não pode ser vazio!"
        }
        if(cc.length == 0) {
            throw "Conta Corrente não pode ser vazio!"
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
        let valDeposito = document.getElementById("valorDeposito").value

        if(valDeposito.length == 0) {
            throw "Valor é necessário!"
        }

        if(valDeposito <= 0) {
            throw "Somente valores positivos!"
        }

        saldoTotal += parseFloat(valDeposito)
        console.log(saldoTotal)
        err = "Saldo atual: R$" + saldoTotal.toString()
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

    document.getElementById("saldoValue").innerHTML = "R$" + saldoTotal.toString()
}

const debitar = () => {
    let err

    try {
        let valDebito = document.getElementById("valorDebito").value

        if(valDebito.length == 0) {
            throw "Valor é necessário!"
        }

        if(valDebito > saldoTotal) {
            throw "Você não possui essa quantia disponível!"
        }

        saldoTotal -= parseFloat(valDebito)
        console.log(saldoTotal)
        err = "Saldo atual: R$" + saldoTotal.toString()
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