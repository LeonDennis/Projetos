
const LoginPadrao = "abcd"
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
        throw "Login e/ou senha incorretos, você tem mais" + " " + tentivas + " " + "tentativas."
    }
    if(LoginPadrao == login && senhaPadrao == senha)
    {
        alert("Bem-vindo ao sistema.");
        window.location.href = "cc1.html";
        
    }
}
catch (e){
    alert(e.toString())
    err = e.toString()
}console.log(err)
}
