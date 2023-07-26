"""
32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
ímpares a partir do número informado pelo usuário menor que 10 e maior que zero. 
"""

number = int(input("Digite um número entre 1 e 9: "))

while number <= 0 or number >= 10:
    number = int(input("Digite um número entre 1 e 9: "))

sum_of_squares = 0

for i in range(number, number + 40, 2):
    sum_of_squares += i**2

print(
    f"A soma dos quadrados dos 20 primeiros números ímpares a partir de {number} é {sum_of_squares}")
