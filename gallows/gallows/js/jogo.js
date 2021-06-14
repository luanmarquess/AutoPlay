// var criaJogo = function(sprite){

//     var setPalavraSecreta = function(palavra){
//         palavraSecreta = palavra;
//         getLacunas();
//         getEtapa();

//         console.log(palavraSecreta)  
//     };
    
//     var getLacunas = function(){

//         // lacunas = [];

//         for(var i = 0; i < palavraSecreta.length; i++){
//             lacunas.push("");
//         }
//         return lacunas;
//         console.log(lacunas);
//         console.log(palavraSecreta.length);
        
//     }
    
//     var getEtapa = function(){
//         if (palavraSecreta == ""){
//             etapa = 1;
//         }else{
//             etapa = 2;
//         }
        
//         return etapa;
//     }
    
//     var processaChute = function(chute){
        
//         var exp = new RegExp(chute, 'gi'), // g == varre do início ao fim, sem parar ao encontrar a primeira ocorrência; i == case Insensitive;
//         resultado, acertou = false;
        
//         while(resultado = exp.exec(palavraSecreta)){ // executa a verificação enquanto for true. Se acertou.
//             lacunas[resultado.index] = chute; // resultado.index == da acesso ao index que a letra apareceu
//             acertou = true;
//         }
            
//         if(!acertou){
//             sprite.nextFrame();
//         }
        
        
//         // for (var i = 0; i < palavraSecreta.length; i++){
//             //     if(chute == palavraSecreta.split()){
                
//                 //     }
//                 // }
//                 // includes() == verifica se contém
//                 // indexOf() == verifica o index
                
//             }
            
//             return{
//                 setPalavraSecreta: setPalavraSecreta,
//                 getLacunas: getLacunas,
//                 getEtapa: getEtapa,
//                 processaChute: processaChute
//             }
            
//     var palavraSecreta;
//     var etapa;
//     var lacunas = [];
            
// }
        
        


const criaJogo = sprite => {

    let etapa = 1;
    let lacunas = [];
    let palavraSecreta = '';

    const ganhou =  () => lacunas.length // se lacunas.length for 0, retorna falso. Se não, procegue para o .some() 
        ? !lacunas.some(function(lacuna){ // checa se há algum item do array vazio;
            return lacuna == '';
        })
        : false;

    const perdeu = () => sprite.isFinished(); // retorna true se acabaram as sprites;

    const ganhouOuPerdeu = () => ganhou() || perdeu();

    const reinicia = () => {
        etapa = 1;
        lacunas = [];
        palavraSecreta = "";
        sprite.reset();
    };

    const processaChute = chute =>  { // arrowFunction que recebe apenas um parâmetro pode-se omitir os parenteses
        if(!chute.trim()) throw Error("Chute inválido!");

        const exp = new RegExp(chute, 'gi');
        let resultado, acertou = false;

        while (resultado = exp.exec(palavraSecreta)){
            acertou = lacunas[resultado.index] = chute;
        }

        if (!acertou) sprite.nextFrame();
    };

    const criaLacunas = () =>  {

        for (let i = 0; i < palavraSecreta.length; i++) {
            lacunas.push('');
        }
    };

    const proximaEtapa = () => etapa = 2;
 

    const setPalavraSecreta = palavra =>  {
        if(!palavra.trim()) throw Error("Palavra secreta inválida!");
        palavraSecreta = palavra;
        criaLacunas();
        proximaEtapa();
    };

    const getLacunas = () => lacunas;

    const getEtapa = () => etapa;


    return { // quando propriedade tem o mesmo nome da variável que será atribuida, pode-se omitir a mesma.
        setPalavraSecreta,
        getLacunas,
        getEtapa,
        processaChute,
        ganhou,
        perdeu,
        ganhouOuPerdeu, 
        reinicia
    }
};
