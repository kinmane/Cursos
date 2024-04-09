"""
25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, 
utilizando as seguintes fórmulas: (h = altura) 
- Para homens: (72.7*h) - 58 
- Para mulheres: (62.1 *h) - 44.7 
"""

height = float(input("Digite sua altura: "))
sex = input("Digite seu sexo [M/F]: ").upper()

if (sex == "M"):
    weight = (72.7 * height) - 58
    print(f"Seu peso ideal é: {weight}")
elif (sex == "F"):
    weight = (62.1 * height) - 44.7
    print(f"Seu peso ideal é: {weight}")
else:
    print("Sexo inválido.")
