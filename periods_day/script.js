function carregar(){
    var mensagemHoras = document.getElementById("div_msg");
    var mensagemPeriodoDia = document.getElementById("div_msg_periodo_dia");

    var mudaImagem  = document.getElementById("img_fases_dia"); // começa recebendo manhã

    var mudaCorFnd = document.getElementById("fnd");


    var data = new Date() //pega a data atual
    var hora = data.getHours()//pega hora atual

    if(hora >= 0 && hora < 12){
        mensagemPeriodoDia.innerHTML = "Bom dia! \n";
        mensagemHoras.innerHTML = "Agora são, " + hora +" horas da manhã.\n"; 
        mudaImagem = document.getElementById("img_fases_dia").src="img/manha.png"
        mudaCorFnd.style.background = "yellow";

        
    }
    else if(hora >= 12 && hora < 18){
        mensagemPeriodoDia.innerHTML = "Boa Tarde!\n";
        mensagemHoras.innerHTML = "Agora são, " + hora +" horas da tarde.\n"; 
        mudaImagem = document.getElementById("img_fases_dia").src="img/tarde.png";
        mudaCorFnd.style.background = "darkorange";
    }
    else{
        mensagemPeriodoDia.innerHTML = "Boa Noite!\n";
        mensagemHoras.innerHTML = "Agora são, " + hora +" horas da noite.\n"; 
        mudaImagem = document.getElementById("img_fases_dia").src="img/noite.png";
        mudaCorFnd.style.background = "midnightblue";
    }

}
