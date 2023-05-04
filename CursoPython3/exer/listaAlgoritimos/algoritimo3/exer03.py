"""
3) Desenvolver um algoritmo que leia um número não determinado de valores e calcule e escreva a
média aritmética dos valores lidos, a quantidade de valores positivos, a quantidade de valores
negativos e o percentual de valores negativos e positivos.
"""

sum = 0
num_positives = 0
num_negatives = 0
total_num = 0

while True:
    valor = float(input("Digite um valor (digite 0 para sair): "))

    if valor == 0:
        break

    sum += valor
    total_num += 1

    if valor > 0:
        num_positives += 1
    else:
        num_negatives += 1

media = sum / total_num
percent_positives = (num_positives / total_num) * 100
percent_negatives = (num_negatives / total_num) * 100

print(f"Média: {media:.2f}")
print(f"Quantidade de valores positivos: {num_positives}")
print(f"Quantidade de valores negativos: {num_negatives}")
print(f"Percentual de valores positivos: {percent_positives:.2f}%")
print(f"Percentual de valores negativos: {percent_negatives:.2f}%")

