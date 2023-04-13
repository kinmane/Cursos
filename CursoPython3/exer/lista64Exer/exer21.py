"""
21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é 
positivo ou negativo. Pare a execução do programa quando o usuário requisitar. 
"""

num = int(input("Informe um número inteiro:"))

if (num >= 0):
    print(f"O número {num} é positivo.")
else:
    print(f"O número {num} é negativo.")
