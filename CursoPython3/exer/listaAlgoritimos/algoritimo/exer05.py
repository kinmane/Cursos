"""
5. Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o
preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no
tanque.
"""

price = float(input("Digite o preço do litro da gasolina: "))
payment = float(input("Digite o valor do pagamento: "))

liters = payment / price

print(f"O motorista conseguiu colocar {liters:.2f} litros no tanque")
