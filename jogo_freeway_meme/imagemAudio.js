//imagens
let imagemDaEstrada;
let imagemAtor;
let imagemCarroVerdeSuperior;
let imagemCarroVerdeInferior;
let imagemCarroPretoSuperior;
let imagemCarroPretoInferior;
let imagemCarroAmareloSuperior;
let imagemCarroAmareloInferior;

//sons
let somTrilhaSonora; 
let somColisao; 
let somPonto;

function preload(){
  imagemDaEstrada = loadImage("imagens/estrada.png"); 
  imagemAtor = loadImage("imagens/faustao.png"); 
  imagemCarroVerdeSuperior = loadImage("imagens/carro-1.png");
  imagemCarroVerdeInferior = loadImage("imagens/carro-1-2.png");
  imagemCarroPretoSuperior = loadImage("imagens/carro-2-2.png");
  imagemCarroPretoInferior = loadImage("imagens/carro-2.png");
  imagemCarroAmareloSuperior = loadImage("imagens/carro-3-2.png");
  imagemCarroAmareloInferior = loadImage("imagens/carro-3-2.png");
  
  imagemCarros = [imagemCarroVerdeSuperior,imagemCarroPretoSuperior,imagemCarroAmareloSuperior,imagemCarroPretoInferior,imagemCarroAmareloInferior,imagemCarroVerdeInferior];
  
  somTrilhaSonora = loadSound("sons/trilhaSonora.mpeg");
  somPontos = loadSound("sons/ponto.mpeg");
  somColisao = loadSound("sons/colisao.mpeg");

}
