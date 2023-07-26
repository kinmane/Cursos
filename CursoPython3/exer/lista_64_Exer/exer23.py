"""
23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
1 – Adição 
2 – Subtração 
3 – Multiplicação 
4 – Divisão 
"""

option = 0

while (option != 5):
    print("Escolha uma opção:")
    print("1 - Adição")
    print("2 - Subtração")
    print("3 - Multiplicação")
    print("4 - Divisão")
    print("5 - Sair")

    option = int(input("Op: "))

    print("Informe o primeiro número:")
    num1 = int(input())
    print("Informe o segundo número:")
    num2 = int(input())

    if (option == 1):
        addition = num1 + num2
        print(f"A soma entre {num1} e {num2} é igual a {addition}")
        break
    elif (option == 2):
        subtraction = num1 - num2
        print(f"A subtração entre {num1} e {num2} é igual a {subtraction}")
        break
    elif (option == 3):
        multiplication = num1 * num2
        print(
            f"A multiplicação entre {num1} e {num2} é igual a {multiplication}")
        break
    elif (option == 4):
        division = num1 / num2
        print(f"A divisão entre {num1} e {num2} é igual a {division}")
        break
    elif (option == 5):
        print("Saindo...")
        break
    else:
        print("Opção inválida!")
