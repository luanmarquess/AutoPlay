// function expression: var nomeVariável = function(){}
const createSprite = selector =>{

    const moveFrame = (from, to)  => {

        $el.removeClass(from) // Remove a classe atual
        .addClass(to); // adiciona a classe do indece subsequente
}
    const hasNext = () => currentFrame + 1 <= lastFrame; //limita o nextFrame para não entrar em loop infinito;


    const nextFrame = () => {

        if(hasNext()) moveFrame(frames[currentFrame], frames[++currentFrame]);
    }


    const reset = () => {
        moveFrame(frames[currentFrame],frames[0]);
        currentFrame = 0;
    }

    const isFinished = () => !hasNext(); // retorna true quando não tiver mais frame

    
    let $el = $(selector); // jquery "$" indica que a variável guarda um jquery object
  
    const frames = ['frame1', 'frame2', 'frame3', 'frame4', 'frame5', 'frame6', 'frame7', 'frame8', 'frame9'];

    let currentFrame = 0;
    const lastFrame = frames.length - 1;

    $el.addClass(frames[currentFrame]);
    


    return{
        nextFrame,
        reset,
        isFinished
    }
}
//function Declaration: Permite chamar a função antes dela ser declarada.
// createSprite(selector);
// function createSprite(selector){}

// function createSprite(selector){
//     var $el = $(selector); // jquery "$" indica que a variável guarda um jquery object
  
//     var frames = ['frame1', 'frame2', 'frame3', 'frame4', 'frame5', 'frame6', 'frame7', 'frame8', 'frame9'];

//     var currentFrame = 0;
//     var lastFrame = frames.length - 1;

//     $el.addClass(frames[currentFrame]);
    

//     function moveFrame(from, to) {
//         $el.removeClass(from) // Remove a classe atual
//         .addClass(to); // adiciona a classe do indece subsequente
// }
//     function hasNext(){
//         return currentFrame + 1 <= lastFrame; //limita o nextFrame para não entrar em loop infinito;
//     }

//     function nextFrame(){

//         if(hasNext()) moveFrame(frames[currentFrame], frames[++currentFrame]);
//     }

//     return{
//         nextFrame: nextFrame
//     }
// }