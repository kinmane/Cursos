"""
11. Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um
algoritmo para converter este tempo em anos, meses e dias. Assuma que cada mês possui sempre
30 dias.
"""

dias = int(input("Digite a quantidade de dias sem acidentes: "))

anos = dias // 365  # // é divisão inteira
meses = (dias % 365) // 30
dias = (dias % 365) % 30

print("Anos: ", anos)
print("Meses: ", meses)
print("Dias: ", dias)
