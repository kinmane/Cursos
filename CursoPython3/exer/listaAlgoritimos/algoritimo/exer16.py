"""
16. A lanchonete Gostosura vende apenas um tipo de sanduíche,
cujo recheio inclui duas fatias de
queijo, uma fatia de presunto e uma rodela de hambúrguer.
Sabendo que cada fatia de queijo ou
presunto pesa 50 gramas, e que a rodela de hambúrguer pesa 100 gramas,
faça um algoritmo em
que o dono forneça a quantidade de sanduíches a fazer,
e a máquina informe as quantidades (em
quilos) de queijo, presunto e carne necessários para compra.
"""

sandwich = int(input("Digite a quantidade de sanduíches: "))

cheese = sandwich * 2 * 0.05
ham = sandwich * 0.05
meat = sandwich * 0.1

print("A quantidade de queijo é: ", cheese, "kg")
print("A quantidade de presunto é: ", ham, "kg")
print("A quantidade de carne é: ", meat, "kg")
