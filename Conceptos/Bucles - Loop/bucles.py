# Bucle while
print("Bucle while. Imprime el número hasta que el número sea mayor o igual a 10")
numero = 0
while numero <= 10:
    print(numero)
    numero += 1


# Bucle for
print("Bucle for. Imprime todos los elementos de una lista")

lista = ["a", "b", "c"]
for letra in lista:
    print(letra)

# Bucle do-while
print("Bucle do-while. Imprime el número, y si el número no es igual a 2, cancelalo")

numero = 0
while True:
    print(numero)
    numero += 1
    if not numero == 2:
        break
