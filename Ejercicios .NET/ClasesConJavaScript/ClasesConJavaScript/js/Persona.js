//Contructor de la clase
function Persona(nombre, edad) {
    this.nombre = nombre;
    this.edad = edad;
}
//Método de la clase
Persona.prototype.mostrarPersona = function () {
    alert("Hola " + this.nombre + " " + this.edad);
}
