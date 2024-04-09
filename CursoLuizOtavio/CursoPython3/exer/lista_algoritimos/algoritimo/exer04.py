"""
4. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida
ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa
com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935
DIAS
"""

name = input("Digite o seu nome: ")
age = int(input("Digite a sua idade: "))

days = age * 365

print(name, ", você já viveu ", days, " dias")
