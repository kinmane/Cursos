option = ''

while option != '0':
    print('*---------------*')
    print('1- Soma')
    print('2- Subtração')
    print('3- Multiplicação')
    print('4- Divisão')
    print('0- Sair')
    print('*---------------*')

    option = input('Digite a opção desejada: ')

    try:
        option = int(option)
    except:
        print('Opção inválida!')
        continue

    if option == 0:
        print('Saindo...')
        break

    if option < 0 or option > 4:
        print('Opção inválida!')
        continue

    num1 = input('Digite o primeiro número: ')
    num2 = input('Digite o segundo número: ')

    try:
        num1 = float(num1)
        num2 = float(num2)
    except:
        print('Número inválido!')
        continue

    if option == 1:
        print(f'{num1} + {num2} = {num1 + num2}')
    elif option == 2:
        print(f'{num1} - {num2} = {num1 - num2}')
    elif option == 3:
        print(f'{num1} * {num2} = {num1 * num2}')
    elif option == 4:
        if num2 == 0:
            print('Não é possível dividir por 0!')
        else:
            print(f'{num1} / {num2} = {num1 / num2}')
