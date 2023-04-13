"""
33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de 
alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.
"""

count = 0
total = 0

grade = float(input("Digite a nota do primeiro aluno (ou -1 para sair): "))

while grade != -1:
    total += grade
    count += 1

    grade = float(input("Digite a nota do próximo aluno (ou -1 para sair): "))

if count > 0:
    average = total / count
    print(f"A média das notas da turma é {average:.2f}")
else:
    print("Nenhuma nota foi inserida.")
