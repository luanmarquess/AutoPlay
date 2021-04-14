var selectedFilm = "";
var selectedDate = "";
var selectedHours = "";
var type = "";
var selectedColumn = "";
var selectedRow = ""
var selectedTicket = "";

function onOpening(){
    var cinema = document.getElementById("cinema").src="img/cinema.png";
    var fristFilm = document.getElementById("fristFilm").src="img/aViuvaDasSombras.png";
    var secondFilm = document.getElementById("secondFilm").src="img/mulherMaravilha1984.png";
    var thirdFilm = document.getElementById("thirdFilm").src="img/tomJerryOFilme.png";
    var fourthFilm = document.getElementById("fourthFilm").src="img/monsterHunter.png";
    var popCorn = document.getElementById("popCorn").src="img/pipoca.png";
    }
    

function filmSelection(){
    var films = document.getElementsByName("films");
    for (var i = 0; i < films.length; i++){
        if(films[i].selected){
            selectedFilm = films[i].value;
            console.log(selectedFilm);
        }
    }
}

function selectDate(){
    var dates = document.getElementsByName("dates");
    for (var i = 0 ; i < dates.length; i ++){
        if(dates[i].selected){
            selectedDate = dates[i].value;
            console.log(selectedDate);
        }
    }
}

function selectHour(){
    var hours = document.getElementsByName("hours");
    for (var i = 0 ; i < hours.length; i ++){
        if(hours[i].selected){
            selectedHours = hours[i].value;
            console.log(selectedHours);
        }
    }
}

function price(){
    var prices = document.getElementsByName("prices");
    for (var i = 0 ; i < prices.length; i ++){
        if(prices[i].selected){
            type = prices[i].value;
            console.log(type);
        }
    }
}

function columnsSelection(){
    var columns = document.getElementsByName("columns");
    for (var i = 0 ; i < columns.length; i ++){
        if(columns[i].selected){
            selectedColumn = columns[i].value;
            console.log(selectedColumn);
        }
    }
}

function rowSelection(){
    var rows = document.getElementsByName("rows");
    for (var i = 0 ; i < rows.length; i ++){
        if(rows[i].selected){
            selectedRow = rows[i].value;
            console.log(selectedRow);
        }
    }
}

function buy(){
    var filmInfo = document.getElementById("filmInfo");
    var dateInfo = document.getElementById("dateInfo");
    var hourInfo = document.getElementById("hourInfo");
    var placeInfo = document.getElementById("placeInfo");
    var buyInfo = document.getElementById("buyInfo");
    var message = document.getElementById("message");

    if(selectedFilm == "" || selectedDate == "" || selectedHours == "" || selectedRow == "" || selectedColumn == "" || type == ""){
        alert("Preencha todos os campos antes de finalizar a compra.");
    } else {
        var ticket = document.getElementById("ticket").src="img/ticketCinema.png"
        filmInfo.innerHTML = "Filme: " + selectedFilm;
        dateInfo.innerHTML = "Data: " + selectedDate;
        hourInfo.innerHTML = "Hora: " + selectedHours;
        placeInfo.innerHTML = "Assento: " + selectedRow + selectedColumn;
        buyInfo.innerHTML = "Tipo de Ingresso: " + type ;
        message.innerHTML = "BOM FILME!"
    }
}