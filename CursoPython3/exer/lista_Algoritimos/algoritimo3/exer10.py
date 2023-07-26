"""
10) Escreva um algoritmo que leia um valor inicial A e imprima a seqüência de valores do cálculo de
A! e o seu resultado. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
"""

a = int(input("Digite um valor: "))
fatorial = 1
for i in range(1, a + 1):
    fatorial = fatorial * i
    print(f"{i}! = {fatorial}")

print(f"O fatorial de {a} é {fatorial}")
