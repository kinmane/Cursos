"""
12) Escreva um programa que leia um número inteiro e exiba o seu módulo. 
O módulo de um número x é: 
x se x é maior ou igual a zero 
x * (-1) se x é menor que zero
"""

number = int(input('Digite um número: '))

if (number >= 0):
    print(f'O módulo de {number} é: {number}')
else:
    print(f'O módulo de {number} é: {number * (-1)}')
