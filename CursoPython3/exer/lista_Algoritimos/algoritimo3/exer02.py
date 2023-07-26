"""
2) Desenvolver um algoritmo que leia a altura de 15 pessoas. Este programa deverá calcular e
mostrar :
a. A menor altura do grupo;
b. A maior altura do grupo;
"""

heights = []
for i in range(1, 16):
    height = float(input(f"Digite a altura da {i}ª pessoa: "))
    heights.append(height)

print(f"A menor altura do grupo é {min(heights)}")
print(f"A maior altura do grupo é {max(heights)}")
