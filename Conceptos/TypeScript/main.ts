// Calculadora #DetectaLaLógica con TypeScript

// Definimos las operaciones matemáticas básicas
const operaciones = {
    suma: (a, b) => a + b,
    resta: (a, b) => a - b,
    multiplicacion: (a, b) => a * b,
    division: (a, b) => a / b,
  };
  
// Definimos la función principal de la calculadora
function calcular(numero1, numero2, operacion) {
    // Validamos que las operaciones sean válidas
    if (operacion === "suma") {
      return operaciones.suma(numero1, numero2);
    } else if (operacion === "resta") {
      return operaciones.resta(numero1, numero2);
    } else if (operacion === "multiplicacion") {
      return operaciones.multiplicacion(numero1, numero2);
    } else if (operacion === "division") {
      return operaciones.division(numero1, numero2);
    } else {
      throw new Error("Operación no válida");
    }
  }
  
// Imprimimos el resultado de la operación
const resultado = calcular(10, 20, "suma");
console.log(resultado);