"""
5) Faça um algoritmo estruturado que leia uma quantidade não determinada de números positivos.
Calcule a quantidade de números pares e ímpares, a média de valores pares e a média geral dos
números lidos. O número que encerrará a leitura será zero.
"""

num_sum = 0
count = 0
even_sum = 0
even_count = 0

while True:
    num = int(input("Digite um número positivo (digite 0 para sair): "))

    if num == 0:
        break

    if num > 0:
        num_sum += num
        count += 1

        if num % 2 == 0:
            even_sum += num
            even_count += 1

if count == 0:
    print("Nenhum número positivo foi digitado.")
else:
    mean = num_sum / count
    print(f"Média geral dos números: {mean:.2f}")

    if even_count == 0:
        print("Nenhum número par foi digitado.")
    else:
        even_mean = even_sum / even_count
        print(f"Média dos números pares: {even_mean:.2f}")

    odd_count = count - even_count
    print(f"Quantidade de números pares: {even_count}")
    print(f"Quantidade de números ímpares: {odd_count}")

