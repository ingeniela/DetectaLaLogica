nota = 9

if nota >= 9:
  print("Excelente")
elif nota >= 7:
  print("Bueno")
elif nota >= 5:
  print("Suficiente")
else:
  print("Insuficiente")

  
nota = 5
edad = 18
tiene_beca = True

if nota >= 9:
  print("Excelente")
elif nota >= 7:
  print("Bueno")
elif nota >= 5:
  if edad >= 18 and tiene_beca:
    print("Suficiente, pero tienes beca")
  else:
    print("Suficiente")
else:
  print("No has aprobado")
