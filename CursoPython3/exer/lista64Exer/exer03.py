"""
Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os 
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis 
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo, 
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
multiplicações.
"""

a = int(input("Informe o valor de A: "))
b = int(input("Informe o valor de B: "))
c = int(input("Informe o valor de C: "))
d = int(input("Informe o valor de D: "))

ab_sum = a + b
ac_sum = a + c
ad_sum = a + d
bc_sum = b + c
bd_sum = b + d
cd_sum = c + d

ab_mult = a * b
ac_mult = a * c
ad_mult = a * d
bc_mult = b * c
bd_mult = b * d
cd_mult = c * d

print("Resultados da soma:")
print("A + B =", ab_sum)
print("A + C =", ac_sum)
print("A + D =", ad_sum)
print("B + C =", bc_sum)
print("B + D =", bd_sum)
print("C + D =", cd_sum)

print("Resultados da multiplicação:")
print("A * B =", ab_mult)
print("A * C =", ac_mult)
print("A * D =", ad_mult)
print("B * C =", bc_mult)
print("B * D =", bd_mult)
print("C * D =", cd_mult)
