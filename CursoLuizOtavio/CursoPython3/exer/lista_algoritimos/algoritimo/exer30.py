"""
30. Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas.
Faça um algoritmo que receba o salário fixo de um funcionário
e o valor de suas vendas, calcule e mostre a
comissão e o salário final do funcionário.
"""

salary = float(input('Digite o salário do funcionário: '))
sales = float(input('Digite o valor das vendas: '))

commission = sales * 0.04

print(f'A comissão é: {commission:.2f}')
print(f'O salário final é: {salary + commission:.2f}')
