"""
8. Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir a sua média
ponderada (as notas tem pesos respectivos de 1, 2 e 3).
"""

grade1 = float(input("Digite a primeira nota: "))
grade2 = float(input("Digite a segunda nota: "))
grade3 = float(input("Digite a terceira nota: "))

average = (grade1 * 1 + grade2 * 2 + grade3 * 3) / 6

print(f"A média ponderada é {average:.2f}.")
