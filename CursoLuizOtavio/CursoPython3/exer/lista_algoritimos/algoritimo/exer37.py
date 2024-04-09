"""
37. Faça um algoritmo que calcule
e mostre a tabuada de um número digitado pelo usuário.
"""

num = int(input("Digite um número: "))

for i in range(1, 11):
    print(f"{num} x {i} = {num * i}")
