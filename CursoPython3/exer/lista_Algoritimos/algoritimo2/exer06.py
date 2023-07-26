"""
6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e então determina se ambos são
VERDADEIROS ou FALSOS.
"""

a = bool(input("Digite o valor de A: "))
b = bool(input("Digite o valor de B: "))

if a == True and b == True:
    print("Ambos são verdadeiros.")
elif a == False and b == False:
    print("Ambos são falsos.")
else:
    print("Um dos valores é falso.")
