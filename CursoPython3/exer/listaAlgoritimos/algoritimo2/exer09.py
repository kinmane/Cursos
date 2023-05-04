"""
9) Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
calcule seu peso ideal, utilizando as seguintes fórmulas:
● para homens: (72.7 * h) – 58;
● para mulheres: (62.1 * h) – 44.7.
"""

height = float(input("Digite sua altura: "))
sex = input("Digite seu sexo (M/F): ").upper()

if sex == "M":
    print("Seu peso ideal é: ", (72.7 * height) - 58)
else:
    print("Seu peso ideal é: ", (62.1 * height) - 44.7)
    