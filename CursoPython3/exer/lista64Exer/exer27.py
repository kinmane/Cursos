"""
27) Escreva um programa que leia: 
- a quantidade de números que deverá processar; 
- os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial. 
Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 
"""

qty = int(input("Digite a quantidade de números que deseja processar: "))

for i in range(qty):
    num = int(input("Digite o número que deseja calcular o fatorial: "))

    factorial = 1
    for j in range(1, num + 1):
        factorial *= j

    print(f"O fatorial de {num} é {factorial}")
