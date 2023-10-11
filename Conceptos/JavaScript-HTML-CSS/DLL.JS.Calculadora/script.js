console.log("Bienvenido a esta calculadora #DetectaLaLógica:")

function obtener(){
  var num1 = parseInt(document.getElementById("number1").value);
  var num2 = parseInt(document.getElementById("number2").value);

  var operator = document.getElementById("operator").value;

  console.log(num1 + operator + num2);
  
  switch(operator){
    case "+":
      result = num1 + num2;
      console.log(result);
      break;
    case "-":
      result = num1 - num2;
      console.log(result);
      break;
    case "*":
      result = num1 * num2;
      console.log(result);
      break;
    case "/":
      result = num1 / num2;
      console.log(result);
      break;
  }

  document.getElementById("result").value = result;
}