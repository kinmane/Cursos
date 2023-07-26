"""
20. Uma confecção produz X blusas de lã e para isto gasta uma certa quantidade de novelos. Faça
um algoritmo para calcular quantos novelos de lã ela gasta por blusa.
"""

qty = int(input("Quantas blusas de lã a confecção produz? "))
qty_novels = int(input("Quantos novelos de lã a confecção gasta por blusa? "))
qty_novels_total = qty * qty_novels

print(f"A confecção gasta {qty_novels_total} novelos de lã para produzir {qty} blusas de lã.")
