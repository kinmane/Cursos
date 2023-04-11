"""
1) Faça um programa para calcular o estoque médio de uma peça, sendo que: 
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
"""

qty_min = int(input("Quantidade mínima: "))
qty_max = int(input("Quantidade máxima: "))

avarege = (qty_min * qty_max) / 2

print(f"Estoque médio: {avarege}")
# print(f"Estoque médio: {(qty_min + qty_max) / 2}")
