"""
Calculadora com while
"""

opicao = 0

while opicao != 5:
    print('1 - Soma')
    print('2 - Subtração')
    print('3 - Multiplicação')
    print('4 - Divisão')
    print('5 - Sair')
    opicao = int(input('Digite a opção desejada: '))
    if opicao == 1:
        num1 = int(input('Digite o primeiro número: '))
        num2 = int(input('Digite o segundo número: '))
        print(f'O resultado da soma é {num1 + num2}')
    elif opicao == 2:
        num1 = int(input('Digite o primeiro número: '))
        num2 = int(input('Digite o segundo número: '))
        print(f'O resultado da subtração é {num1 - num2}')
    elif opicao == 3:
        num1 = int(input('Digite o primeiro número: '))
        num2 = int(input('Digite o segundo número: '))
        print(f'O resultado da multiplicação é {num1 * num2}')
    elif opicao == 4:
        num1 = int(input('Digite o primeiro número: '))
        num2 = int(input('Digite o segundo número: '))
        print(f'O resultado da divisão é {num1 / num2}')
    elif opicao == 5:
        print('Obrigado por utilizar nossa calculadora!')
    else:
        print('Opção inválida!')
