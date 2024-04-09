"""
5- Fazer um programa para ler o código de uma peça 1, o número de peças 1,
o valor unitário de cada peça 1, o código de uma peça 2,
o número de peças 2 e o valor unitário de cada peça 2.
Calcule e mostre o valor a ser pago.
"""

cod_piece1 = int(input("Informe o código da peça 1: "))
num_piece1 = int(input("Informe a quantidade de peças 1: "))
price_piece1 = float(input("Informe o valor da peça 1: "))

cod_piece2 = int(input("Informe o código da peça 2: "))
num_piece2 = int(input("Informe a quantidade de peças 2: "))
price_piece2 = float(input("Informe o valor da peça 2: "))

value_piece1 = num_piece1 * price_piece1
value_piece2 = num_piece2 * price_piece2

print("O valor total de peças 1 é R$", value_piece1)
print("O valor total de peças 2 é R$", value_piece2)
