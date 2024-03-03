
// Genéricos: Definimos un tipo genérico `Contenedor` 
//que puede almacenar cualquier tipo de dato
interface Contenedor<T> {
    valor: T;
}
  
// Uniones: Definimos un tipo de unión que puede ser un número o una cadena
type NumeroOCadena = number | string;
  
// Intersecciones: Representar tipos que deben cumplir con uno o más tipos
interface Usuario {
    nombre: string;
}
interface Rol {
    administrador: boolean;
}
type UsuarioConRol = Usuario & Rol;