"""
3) Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente
"""

num1 = int(input("Digite o primeiro número: "))
num2 = int(input("Digite o segundo número: "))
num3 = int(input("Digite o terceiro número: "))

maior = num1
if num2 > maior:
    maior = num2
if num3 > maior:
    maior = num3

menor = num1
if num2 < menor:
    menor = num2
if num3 < menor:
    menor = num3

meio = (num1 + num2 + num3) - maior - menor

print(maior, meio, menor)
