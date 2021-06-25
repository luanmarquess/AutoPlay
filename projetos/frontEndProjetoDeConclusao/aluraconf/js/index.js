function transitionSmooth(selector){
   $(selector).click(function(event){ //aplica evento click para o seletor;
        event.preventDefault(); // cancela evento padrão (descer automaticamente rápido);
        let target = $(this).attr('href'); // pega o valor que está no hf do selector;

        $('html, body').animate({
            scrollTop: $(target).offset().top //vê qual o valor top dele e set a transition para 1s
        }, 1000)
   }); 

}

transitionSmooth('a[href*=panel-about]'); //'a[href*=panel-about]' seletor css
transitionSmooth('a[href*=panel-speakers]');
transitionSmooth('a[href*=panel-form]');