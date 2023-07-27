"""
6- Fazer um programa que leia três valores com ponto flutuante de dupla precisão:
A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B
"""

base = float(input("Digite o valor da base (A): "))
height = float(input("Digite o valor da altura (C): "))
radius = float(input("Digite o valor do raio (C): "))
base2 = float(input("Digite o valor da segunda base (B): "))
side = float(input("Digite o valor do lado (B): "))

area_tri_retangulo = (base * height) / 2
area_circulo = 3.14159 * (radius ** 2)
area_trapezio = ((base + base2) * height) / 2
area_quadrado = side ** 2
area_retangulo = base * side

print(f"Área do triângulo retângulo: {area_tri_retangulo:.2f}")
print(f"Área do círculo: {area_circulo:.2f}")
print(f"Área do trapézio: {area_trapezio:.2f}")
print(f"Área do quadrado: {area_quadrado:.2f}")
print(f"Área do retângulo: {area_retangulo:.2f}")
