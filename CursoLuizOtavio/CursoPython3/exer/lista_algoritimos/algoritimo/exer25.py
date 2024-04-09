"""
25. Calcule o volume de uma caixa d'água cilíndrica.
"""

radius = float(input("Digite o valor do raio da base da caixa d'água: "))
height = float(input("Digite o valor da altura da caixa d'água: "))

volume = 3.14159 * radius**2 * height

print(f"O volume da caixa d'água cilíndrica é de {volume:.2f} metros cúbicos.")
