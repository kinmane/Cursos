"""
4) Escrever um algoritmo que leia uma quantidade desconhecida de números e conte quantos deles
estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100]. A entrada de dados deve
terminar quando for lido um número negativo.
"""

count_0_25 = 0
count_26_50 = 0
count_51_75 = 0
count_76_100 = 0

while True:
    num = int(input("Informe um número (negativo para sair): "))

    if num < 0:
        break

    if 0 <= num <= 25:
        count_0_25 += 1
    elif 26 <= num <= 50:
        count_26_50 += 1
    elif 51 <= num <= 75:
        count_51_75 += 1
    elif 76 <= num <= 100:
        count_76_100 += 1

print(f"Quantidade de números no intervalo [0-25]: {count_0_25}")
print(f"Quantidade de números no intervalo [26-50]: {count_26_50}")
print(f"Quantidade de números no intervalo [51-75]: {count_51_75}")
print(f"Quantidade de números no intervalo [76-100]: {count_76_100}")
