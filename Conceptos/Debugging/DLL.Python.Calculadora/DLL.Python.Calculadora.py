print("Calculadora #DetectaLaLógica")

num1 = float(input("Ingrese el primer número: "))
num2 = float(input("Ingrese el segundo número: "))

print("Operaciones:")
print("1. Suma")
print("2. Resta")  
print("3. Multiplicación")
print("4. División")

operacion = input("Seleccione la operación (1/2/3/4): ")

if operacion == '1':
    print(num1, "+", num2, "=", num1 + num2)

elif operacion == '2':
    print(num1, "-", num2, "=", num1 - num2)

elif operacion == '3':
    print(num1, "*", num2, "=", num1 * num2)

elif operacion == '4':
    print(num1, "/", num2, "=", num1 / num2)

else:
    print("Operación inválida")