"""
35. Faça um algoritmo que calcule e mostre a área de um losango.
Sabe-se que: A = (diagonal_maior * diagonal_menor)/2;
"""

diag_big = float(input("Digite o valor da diagonal maior: "))
diag_small = float(input("Digite o valor da diagonal menor: "))

area = (diag_big * diag_small)/2

print("A área do losango é: ", area)
