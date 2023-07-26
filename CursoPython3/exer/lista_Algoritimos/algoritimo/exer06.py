"""
6. O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a
balança já desconte o peso do prato.
"""

height = float(input("Digite o peso do prato (em quilos): "))

price = height * 12

print(f"O valor a pagar é R${price:.2f}")
