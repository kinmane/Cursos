"""
21. A fábrica de refrigerantes Meia-Cola vende seu produto em três formatos:
lata de 350 ml, garrafa de 600 ml e garrafa de 2 litros.
Se um comerciante compra uma determinada quantidade de cada formato,
faça um algoritmo para calcular quantos litros de refrigerante ele comprou.
"""

can = int(input("Quantas latas você comprou? "))
bottle_600 = int(input("Quantas garrafas de 600ml você comprou? "))
bottle_1 = int(input("Quantas garrafas de 1l você comprou? "))

total = can * 0.35 + bottle_600 * 0.6 + bottle_1 * 2

print(f"Você comprou {total} litros de refrigerante")
