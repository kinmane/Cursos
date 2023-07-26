"""
8) Escreva um algoritmo que leia um valor inicial A e uma razão R e imprima uma seqüência em
P.A. contendo 10 valores.
"""

a = int(input("Digite o valor inicial: "))
r = int(input("Digite a razão: "))
for i in range(10):
    print(a)
    a += r
