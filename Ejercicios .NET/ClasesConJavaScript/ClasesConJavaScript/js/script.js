//Creamos un método que se llama app
var app = function () {
    var Programmer = new Programmers("Alex", 30);
    Programmer.obtener();
}

//Creamos un método que se llama otroMetodo
var otroMetodo = function () {
    var pro = new Programmers("Hey", 50);
    pro.obtener();
    localStorage.setItem("titulo", "Curso de Angular avanzado - Víctor Robles");
}

//Creamos un método que se llama metodoPersona
var metodoPersona = function () {
    var nombre = document.getElementById("txtNombre").value;//Recoge el valor que tiene la etiqueta con el id txtNombre
    var edad = document.getElementById("txtEdad").value;//Recoge el valor que tiene la etiqueta con el id txtEdad
    var persona = new Persona(nombre, edad);//Instanciamos el objeto
    persona.mostrarPersona();//Llamamos al método de ese objeto
    localStorage.setItem(nombre, edad);//Guardamos en LocalStorage esos valores(key,valor)
}