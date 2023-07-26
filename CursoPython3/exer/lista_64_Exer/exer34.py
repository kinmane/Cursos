"""
34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o 
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
fim dos dados.
"""

smallest = float('inf')
largest = float('-inf')

while True:
    num = float(
        input("Digite um número positivo (ou um número negativo para encerrar): "))

    if num < 0:
        break

    if num < smallest:
        smallest = num
    if num > largest:
        largest = num

    if smallest != float('inf') and largest != float('-inf'):
        print(f"O menor valor é {smallest:.2f}")
        print(f"O maior valor é {largest:.2f}")
