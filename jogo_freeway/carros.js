let xCarros = [530,-30,-30,530,-30,-30];
let yCarros = [45,105,155,215,270,325];
let velocidade = [-10,3,3.5,-6,5,3];
let comprimentoCarro = 35;
let alturaCarro = 30;

function mostraCarros(){
  for (let i = 0; i < imagemCarros.length; i++){
    image(imagemCarros[i], xCarros[i],yCarros[i],comprimentoCarro,alturaCarro);
  }
}

function movimentaCarros(){
  for (let i = 0 ; i < xCarros.length; i++){
    xCarros[i] += velocidade[i];
  }
}


let xRetorna = [-30,530,530,-30,-30,530];


function retornaPosicaoEsquerda(){
  for(let i = 0; i < xCarros.length; i++){
    if (limiteXDireita(xCarros[i])){ 
    xCarros[i] = -30;
    }
  }
}

function limiteXDireita (xCarros){
  return xCarros > 530;
}

function retornaPosicaoDireita (){
  for (let i = 0; i < xCarros.length; i++){
    if(limiteXEsquerda(xCarros[i])){
      xCarros[i] = 530;
    } 
  }
}

function limiteXEsquerda(xCarros){
  return xCarros < -30;
}
