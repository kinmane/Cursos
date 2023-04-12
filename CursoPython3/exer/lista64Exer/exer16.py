"""
16) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do 
menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato. 
"""

num1 = float(input('Digite o primeiro número: '))
num2 = float(input('Digite o segundo número: '))

if (num1 == num2):
    print('Os números são iguais')
elif (num1 > num2):
    print(f'O maior número é {num1}')
    print(f'O menor número é {num2}')
else:
    print(f'O maior número é {num2}')
    print(f'O menor número é {num1}')
