
//Estamos creando un constructor
function Programmers(name, age) {
    this.name = name;
    this.age = age;
}

//Creamos un método para esta calse que se llama obtener
Programmers.prototype.obtener = function () {
    alert(this.name + " " + this.age);
}


