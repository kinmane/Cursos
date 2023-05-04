"""
7) Faça um algoritmo que leia uma variável e some 5 caso seja par ou some 8 caso seja ímpar,
imprimir o resultado desta operação.
"""

num = int(input("Digite um número: "))

if num % 2 == 0:
    num += 5
    print(f"O número {num} é par!")
    print(f"O número {num} + 5 = {num}")
else:
    num += 8
    print(f"O número {num} é ímpar!")
    print(f"O número {num} + 8 = {num}")
