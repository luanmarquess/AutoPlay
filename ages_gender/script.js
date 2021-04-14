function verificar(){
    var ckGenders = document.getElementsByName("ckGenders"); // chama todos os elementos com o mesmo name e joga em um array

    var bornYearInput = document.getElementById("bornYear").value;
    var date = new Date();
    var year = date.getFullYear();
    var yearsOld = (year - bornYearInput);

    var gender = document.getElementById("typeOfSex");

    var alertNullInput = document.getElementById("alert");

    var changeImg = document.getElementById("img_gender");

    var changeColor = document.getElementById("backGorund");

    if (bornYearInput == "" || bornYearInput < 1910){
        alert("Informe o ano de nascimento válido!");
        alertNullInput.innerHTML = "Preencha os campos antes de finalizar.";
        gender.innerHTML = "";
        changeImg = document.getElementById("img_gender").src="img/nogender.png";
        changeColor.style.background = "grey"
    }

    else if (ckGenders[0].checked){
        alertNullInput.innerHTML = "";
        gender.innerHTML = `Avaliado - Homem, com ${yearsOld} anos de idade!`;
        changeImg = document.getElementById("img_gender").src="img/man.png";
        changeColor.style.background = "black";   
    }

    else if (ckGenders[1].checked){
        alertNullInput.innerHTML = "";
        gender.innerHTML =`Avaliado - Mulher, com ${yearsOld} anos de idade!`;
        changeImg = document.getElementById("img_gender").src="img/woman.png";
        changeColor.style.background = "pink"; 
    }
}

