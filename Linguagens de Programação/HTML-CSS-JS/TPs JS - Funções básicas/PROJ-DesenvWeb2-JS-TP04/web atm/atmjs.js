var aviso = alert("Feito por Leon Dennis, RA 171353, Noturno.")
const LoginPadrao = "Medina"
const senhaPadrao = "1234"
let tentivas = 3

const logar =() =>{
    let err
try {
   let login = document.getElementById("login").value
   let senha = document.getElementById("senha").value
   console.log("foi")
   if(login.length == 0){
       throw "O Login é obrigatório."
       
   }
    if(senha.length == 0){
        throw "A Senha é obrigatória."
    }   
    if(tentivas == 1){
        throw "O seu cartão foi cancelado por muitas tentativas, entre em contato com o gerente do banco."
    }
    if((senhaPadrao != senha || LoginPadrao != login) && tentivas > 1){
        tentivas--
        throw "Login e/ou senha incorretos, você tem mais" + tentivas + "tentativas."
    }
    if(LoginPadrao == login && senhaPadrao == senha){
        throw "Bem-vindo ao sistema."
    }
}
catch (e){
    alert(e.toString())
    err = e.toString()
}console.log(err)
}
