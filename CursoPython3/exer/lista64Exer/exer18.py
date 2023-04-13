"""
18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou 
igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é 
um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou 
seja, apresentar a mensagem “um”, ”dois” ou “três”. 
"""

num = int(input('Digite um número: '))

if (num == 1):
    print('Um')
elif (num == 2):
    print('Dois')
elif (num == 3):
    print('Três')
else:
    print('Código inválido')
