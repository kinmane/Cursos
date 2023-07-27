"""
2- Faça um programa para ler o valor do raio de um círculo, 
e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. 
Fórmula da área: area = π . raio2 
Considere o valor de π = 3.14159
"""

radius = float(input("Informe o raio do círculo: "))

pi = 3.14159
area = pi * (radius * radius)

print(f"O valor da area é: {area:.2f}")
