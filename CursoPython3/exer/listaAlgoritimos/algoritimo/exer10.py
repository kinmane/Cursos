"""
10. Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada
ponto é um par ordenado (x,y).
"""

from math import sqrt

x1 = float(input("Entre com a coordenada x do primeiro ponto: "))
y1 = float(input("Entre com a coordenada y do primeiro ponto: "))
x2 = float(input("Entre com a coordenada x do segundo ponto: "))
y2 = float(input("Entre com a coordenada y do segundo ponto: "))

d = sqrt((x2 - x1)**2 + (y2 - y1)**2)

print("A distância entre os pontos ({}, {}) e ({}, {}) é {:.2f}.".format(x1, y1, x2, y2, d))
