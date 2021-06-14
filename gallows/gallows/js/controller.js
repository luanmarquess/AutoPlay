const criaController = (jogo) => {

    const $entrada = $('#entrada');
    const $lacunas = $('.lacunas');

    const exibeLacunas = () => {
        $lacunas.empty();
        jogo.getLacunas().forEach(function(lacuna){
            $('<li>').addClass('lacuna').text(lacuna).appendTo($lacunas); // para cada lacuna, cria uma li e adiciona a classe #lacuna
        });
    };

    const mudaPlaceHolder = texto => $entrada.val("").attr("placeholder", texto);

    const guardaPalavraSecreta = () => {
        try{
            jogo.setPalavraSecreta($entrada.val().trim()); // pega value do inpute joga pra palavra secreta .trim() == tirar espaços esqueda e direita
            $entrada.val(""); // limpa o input
            exibeLacunas();
            mudaPlaceHolder('chute'); 
        }catch(err){
            alert(err.message);
        }
    };

    const reinicia = () => {
        jogo.reinicia();
        $lacunas.empty();
        mudaPlaceHolder("Palavra Secreta")
    }

    const leChute = () => {
        try{
            
            jogo.processaChute($entrada.val().trim().substr(0, 1));
            $entrada.val("");
            exibeLacunas(); 
    
            if(jogo.ganhouOuPerder()){
                setTimeout(() => {
                    if(jogo.ganhou()) {
                        alert('Parabéns, você ganhou!');
                    }else if(jogo.perdeu()) {
                        alert('Que pena, tente novamente');
                    }
                    reinicia();
                }, 200);
            }
        } catch(err){
            alert(err.message);
        }
    };

    const inicia = () => {

        $entrada.keypress(event => {

            if (event.which == 13) {
                switch (jogo.getEtapa()) {
                    case 1:
                        guardaPalavraSecreta();
                        break;
                    case 2:
                        leChute();
                        break;
                }
            }
        });
    }

    return { inicia };
};