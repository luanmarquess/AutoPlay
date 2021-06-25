//Ator
let yAtor = 370;
let xAtor = 250;
let colisao = false;
let pontos = 0
let recordAtual = 0


function mostraAtor(){
  image(imagemAtor,xAtor,yAtor,25,25);
}

function movimentaAtor(){
  if (keyIsDown(UP_ARROW)){
    yAtor -= 2;
  }
  if (keyIsDown(DOWN_ARROW)){
    if (limiteMovimentoAtorParaBaixo()){
      yAtor += 2;
    }
  }
  if (keyIsDown(LEFT_ARROW)){
    if(limiteMovimentoAtorParaEsquerda()){
      xAtor -= 2;
      }
  }
  if (keyIsDown(RIGHT_ARROW)){
    if(limiteMovimetnoAtorParaDireita()){
      xAtor += 2;
    }
  }
}

function verificaColisao(){
  for (let i = 0; i < xCarros.length; i++){
    colisao = collideRectCircle(xCarros[i], yCarros[i], comprimentoCarro, alturaCarro, xAtor, yAtor, 22);  
    if (colisao){  
        record();
        somColisao.play();
        voltaPosicaoInicial();
        pontos = 0  
    }  
  }
}

function voltaPosicaoInicial(){
  yAtor = 368;
  xAtor = 250;
    
}

function placar(){
  textAlign(CENTER);
  textSize(15);
  fill(color(255,215,0));
  text("PONTOS: "+ pontos, 250, 23);
}

function exibeRecord(){
  textSize(15);
  fill(color(255,215,0));
  text("RECORD: "+ recordAtual, 400, 23);
}

function record(){
  if(pontos > recordAtual){
    recordAtual = pontos;
    voltaPosicaoInicial();
  }
}

function marcaPontos(){
  if (yAtor < 15){
    somPontos.play();
    pontos++;
    voltaPosicaoInicial();
  }
}

function limiteMovimentoAtorParaBaixo(){
  return yAtor < 370;
  
}
function limiteMovimentoAtorParaEsquerda(){
  return xAtor > 5;
}
function limiteMovimetnoAtorParaDireita(){
  return xAtor < 470;
}
