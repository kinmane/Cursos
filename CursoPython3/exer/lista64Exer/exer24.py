"""
24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja 
realizar: 
1 – Verificar se um dos números lidos é ou não múltiplo do outro 
2 – Verificar se os dois números lidos são pares 
3 – Verificar se a média dos dois números é maior ou igual a 7. 
4 – Sair 
"""

option = 0

while (option != 4):
    print("Escolha uma opção:")
    print("1 - Verificar se um dos números lidos é ou não múltiplo do outro")
    print("2 - Verificar se os dois números lidos são pares")
    print("3 - Verificar se a média dos dois números é maior ou igual a 7")

    option = int(input("Op: "))

    print("Informe o primeiro número:")
    num1 = int(input())
    print("Informe o segundo número:")
    num2 = int(input())

    if (option == 1):
        if (num1 % num2 == 0 or num2 % num1 == 0):
            print(f"O número {num1} é múltiplo do outro número {num2}.")
        else:
            print(f"O número {num1} não é múltiplo do outro número {num2}.")
        break
    elif (option == 2):
        if (num1 % num2 == 0 and num2 % num1 == 0):
            print(f"O número {num1} e {num2} são pares.")
        else:
            print(f"O número {num1} e {num2} são impares.")
        break
    elif (option == 3):
        if ((num1 + num2) / 2 >= 7):
            print(f"A média dos dois números é maior ou igual a 7.")
        else:
            print(f"A média dos dois números é menor ou igual a 7.")
        break
    elif (option == 4):
        print("Saindo...")
        break
