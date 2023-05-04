"""
1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
"""

a = int(input("Digite o valor de A:"))
b = int(input("Digite o valor de B:"))
c = int(input("Digite o valor de C:"))

if a + b < c:
    print("A soma de A + B é menor que C")
elif a + b == c:
    print("A soma de A + B é igual a C")
else:
    print("A soma de A + B é maior que C")
