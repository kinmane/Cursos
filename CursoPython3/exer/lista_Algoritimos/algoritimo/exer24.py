"""
24. Um tonel de refresco é feito com 8 partes de água mineral e
2 partes de suco de maracujá.
Faça um algoritmo para calcular quantos litros de água e de suco
são necessários para se fazer X litros de refresco (informados pelo usuário).
"""

refreshment = int(input("Quantos litros de refresco você deseja fazer? "))

water_ratio = 8 / 10  # 8 partes de água para 10 partes no total
juice_ratio = 2 / 10  # 2 partes de suco para 10 partes no total

water_needed = refreshment * water_ratio
juice_needed = refreshment * juice_ratio

print(f"Para fazer {refreshment} litros de refresoc, são necessários {water_needed:.2f} litros de água e {juice_needed:.2f} litros de suco.")
