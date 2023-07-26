"""
28. Faça um algoritmo que receba duas notas,
calcule e mostre a média ponderada dessas notas,
considerando peso 2 para a primeira nota e peso 3 para a segunda nota.
"""

grade1 = float(input("Digite a primeira nota: "))
grade2 = float(input("Digite a segunda nota: "))

media = (grade1 * 2 + grade2 * 3) / 5

print(f"A média ponderada das notas é: {media}")
