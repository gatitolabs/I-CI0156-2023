// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const persona  = {
    nombre: "Juan", 
    edad: 23, 
    email: "juan@juanto.com"
}; 

console.table(persona); 
persona.genero = "M"; 
//console.table(persona);
Object.seal(persona);
persona.genero = "F"; 
persona.estado = "soltero";
console.table(persona); 