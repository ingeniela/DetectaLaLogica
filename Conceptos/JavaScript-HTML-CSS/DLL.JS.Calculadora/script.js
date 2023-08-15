function calculate() {
    var number1 = parseInt(document.getElementById("number1").value);
    var number2 = parseInt(document.getElementById("number2").value);
    var operator = document.getElementById("operator").value;
    
    switch (operator) {
      case "+":
        result = number1 + number2;
        break;
      case "-":
        result = number1 - number2;
        break;
      case "*":
        result = number1 * number2;
        break;
      case "/":
        result = number1 / number2;
        break;
    }
  
    document.getElementById("result").value = result;
  }
  
  document.getElementById("equal").addEventListener("click", calculate);