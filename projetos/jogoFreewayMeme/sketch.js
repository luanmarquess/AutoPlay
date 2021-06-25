function setup() {
  createCanvas(500, 400);
  somTrilhaSonora.loop();
}

function draw() {
  
  background(imagemDaEstrada);
  
  mostraAtor();
  movimentaAtor();
  
  mostraCarros();
  movimentaCarros();
  
  retornaPosicaoEsquerda();
  retornaPosicaoDireita();
  
  verificaColisao();
  
  placar();
  exibeRecord();
  marcaPontos();
   
}



