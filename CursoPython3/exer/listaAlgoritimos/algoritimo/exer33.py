"""
33. Faça um algoritmo que calcule e mostre a área de um trapézio.
Sabe-se que: A = (base maior + base menor)* altura)/2 ;
"""

base_big = float(input("Digite a base maior: "))
base_small = float(input("Digite a base menor: "))
height = float(input("Digite a altura: "))

area = ((base_big + base_small) * height) / 2

print("A área do trapézio é: ", area)
