'''
Versão 0.1 todo list console

# Funcionalidades:
* Adicionar novas tarefas.
* Visualizar a lista de tarefas.
* Remover tarefas.

# Estrutura:
* main.py: Arquivo principal que contém a lógica do aplicativo.
'''

import os

opcao = 0
tarefas = []

while opcao != 9:
    print(' ______________________')
    print('| 1 - Adicionar tarefa |')
    print('| 2 - Listar tarefas   |')
    print('| 3 - Remover tarefa   |')
    print('| 9 - Sair             |')
    print('|______________________|')
    opcao = int(input('Digite a opção desejada: '))
    
    if opcao == 1:
        os.system('cls')
        tarefa = input('Digite a tarefa: ')
        tarefas.append(tarefa)
        print('Tarefa adicionada com sucesso!')
    elif opcao == 2:
        os.system('cls')
        print('Tarefas:')
        for tarefa in tarefas:
            print(tarefa)
    elif opcao == 3:
        os.system('cls')
        tarefa = input('Digite a tarefa a ser removida: ')
        if tarefa in tarefas:
            tarefas.remove(tarefa)
            print('Tarefa removida com sucesso!')
        else:
            print('Tarefa não encontrada!')
    elif opcao == 9:
        os.system('cls')
        print('Saindo...')
    else:
        os.system('cls')
        print('Opção inválida!')
        