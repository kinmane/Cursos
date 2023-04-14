"""
9. Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo
vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo em que o usuário forneça a
quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e a máquina
informe quanto será o valor arrecadado.
"""

small = int(input("Digite a quantidade de camisetas pequenas: "))
medium = int(input("Digite a quantidade de camisetas médias: "))
large = int(input("Digite a quantidade de camisetas grandes: "))

total = small * 10 + medium * 12 + large * 15

print(f"O valor arrecadado é R$ {total:.2f}.")
