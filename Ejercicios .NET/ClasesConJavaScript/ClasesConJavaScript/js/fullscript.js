
//Contructor de la clase
function Usuario(user, password, monedaOrigen,monedaDestino,conversion) {
    this.user = user;
    this.password = password;
    this.monedaOrigen = monedaOrigen;
    this.monedaDestino = monedaDestino;
    this.conversion = conversion;
}

var creando = function () {
    var user1 = new Usuario("Pepe", "12345", "EUR", "USD", 68);
    var user2 = new Usuario("Pepe", "12345", "EUR", "USD", 68);

    var currentPersona = JSON.stringify(user1);
    localStorage.setItem("1", currentPersona);
    

    currentPersona = JSON.stringify(user2);
    localStorage.setItem("2", currentPersona);

    var guardado = localStorage.getItem('1');
    JSON.parse(guardado)

    console.log('objetoObtenido: ', JSON.parse(guardado));

}

//var listaPersona = (function () {
//    this.lista = new Array()
//});


//var currentUser = null;
//currentCart = JSON.parse(localStorage.getItem('user'));
//if (!currentUser) {
//    createEmptyUser();
//}

//currentUser.addUser = function (user) {
//    currentUser.listaPersona.push(user);

//    // insert the new cart into the storage as string
//    localStorage.setItem('user', JSON.stringify(currentUser));

//}

//function createEmptyCart() {
//    localStorage.clear();
//    localStorage.setItem("user", JSON.stringify(new listaPersona()));
//    currentUser = JSON.parse(localStorage.getItem("user"));
//}


////Método de la clase
//Persona.prototype.mostrarPersona = function () {
//    alert("Hola " + this.nombre + " " + this.edad);
//}

////Creamos un método que se llama metodoPersona
//var metodoPersona2 = function () {
//    var nombre = document.getElementById("txtNombre").value;//Recoge el valor que tiene la etiqueta con el id txtNombre
//    var edad = document.getElementById("txtEdad").value;//Recoge el valor que tiene la etiqueta con el id txtEdad
//    var persona = new Persona(nombre, edad);//Instanciamos el objeto
//    persona.mostrarPersona();//Llamamos al método de ese objeto
//    localStorage.setItem(nombre, edad);//Guardamos en LocalStorage esos valores(key,valor)
//    localStorage.setItem(nombre, edad);
//}

//var recegerLocalStorage = function () {
//    //var currentUser = localStorage.getItem('user', new Persona());

//    for (var i = 0; i < currentUser.lista.length; i++) {
//        var liElement = document.createElement('li');
//        liElement.innerHTML = currentCart.lista[i].nombre + " " + currentCart.lista[i].edad;
//        document.getElementById("listado").appendChild(liElement);
//    }
//    document.getElementById('lblEdad').innerHTML = currentUser;
//}



