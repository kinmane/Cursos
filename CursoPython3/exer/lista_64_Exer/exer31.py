"""
31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba 
ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o 
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
fim dos dados. 
"""

sum_even = 0
sum_odd = 0

number = int(
    input("Digite um número positivo (ou um número negativo para sair): "))
while number >= 0:
    if number % 2 == 0:
        print(f"{number} é par")
        sum_even += number
    else:
        print(f"{number} é ímpar")
        sum_odd += number

    number = int(
        input("Digite um número positivo (ou um número negativo para sair): "))

print(f"A soma dos números pares é {sum_even}")
print(f"A soma dos números ímpares é {sum_odd}")
