"""
2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e
estado civil seja “CASADA”, solicitar o tempo de casada (anos).
"""

name = input("Digite o seu nome: ")
sex = input("Digite o seu sexo (M / F): ")
marital_status = input("Digite o seu estado civil: ")

if marital_status == 'f':
    time_married = input("Digite o tempo de casada: ")
    print("O tempo de casada é: ", time_married)
