"""
17) Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa 
entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”. 
Caso contrário, apresentar a mensagem “valor inválido”. 
"""

num = int(input('Digite um número inteiro: '))

if (num >= 0 and num <= 9):
    print('Valor válido')
else:
    print('Valor inválido')
