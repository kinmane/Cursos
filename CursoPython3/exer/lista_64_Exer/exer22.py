"""
22) Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o 
resultado. 
"""

num = int(input("Informe um número:"))

if (num >= 0):
    A = num
    print(f"O número {num} é positivo e foi armazenado na váriavel A.")
else:
    B = num
    print(f"O número {num} é negativo e foi armazenado na váriavel B.")
