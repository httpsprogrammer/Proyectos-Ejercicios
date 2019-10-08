//Recoge la etiqueta con el id
var div = document.getElementById('listaUsuarios');

// Clase Usuario
function Usuario(email,password) {
    this.email = email;
    this.password = password;
}

//array de usuarios
var listaUsuarios = new Array();

//Inserta en el localStorage
var setLocalStorage = function () {

    var user = document.getElementById('txtEmail').value;
    var password = document.getElementById('txtPassword').value;

    listaUsuarios.push(new Usuario(user, password));
    var currentLista = JSON.stringify(listaUsuarios);
    localStorage.setItem("user",currentLista);
}

//Recoge los datos del local y los muestra por pantalla
var getLocalStorage = function () {
    var currentLista = localStorage.getItem("user");
    var parseado = JSON.parse(currentLista);
    div.innerHTML += "<p>users: </p>" + "<br>";
    parseado.forEach(imprime);
}

//Recorre e imprime los valores del email con etiquetas de párrafo entre medias
function imprime(item, index) {
    div.innerHTML += "<p>" + item.email + "</p>" + "<br>";


}