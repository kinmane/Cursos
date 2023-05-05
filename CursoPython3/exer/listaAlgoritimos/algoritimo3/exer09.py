"""
9) Escreva um algoritmo que leia um valor inicial A e uma razão R e imprima uma seqüência em
P.G. contendo 10 valores.
"""

A = int(input("Digite o valor inicial: "))
R = int(input("Digite a razão: "))
for i in range(10):
    print(A)
    A *= R
