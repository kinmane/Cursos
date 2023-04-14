"""
29. Faça um algoritmo que receba o preço de um produto,
calcule e mostre o novo preço, sabendo-se que este sofreu um desconto de 10%.
"""

price = float(input('Digite o preço do produto: '))

new_price = price - (price * 0.1)

print(f'O preço com desconto é: {new_price:.2f}')
