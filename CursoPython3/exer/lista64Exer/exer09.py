"""
9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
meses e dias e escreva a idade dessa 
pessoa expressa apenas em dias. 
Considerar ano com 365 dias e mês com 30 dias. 
"""

age = int(input('Informe sua idade: '))
month = int(input('Quantos meses: '))
day = int(input('E os dias: '))

total_days = age * 365 + month * 30 + day

print(f'Sua idade em dias é: {total_days}')
