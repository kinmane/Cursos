import os
from main import adicionar_tarefa, listar_taferas, concluir_tarefa, remover_tarefa

def main ():
    #Exibe o menu principal
    while True:
        print("-" * 20)
        print("Lista de Tarefas")
        print("-" * 20)

        print("1. Adicionar Tarefa")
        print("2. Visualizar Tarefas")
        print("3. Marcar Tarefa como Concluída")
        print("4. Remover Tarefa")
        print("0. Sair")
        
        opcao = input("Escolha uma opção: ")
        
        if opcao == '1':
            os.system('cls')
            titulo = input("Digite o título da tarefa: ")
            descricao = input("Digite a descrição da tarefa: ")
            adicionar_tarefa(titulo, descricao)
            print("Tarefa adicionada com sucesso!")
        elif opcao == '2':
            os.system('cls')
            tarefas = listar_taferas()
            for tarefa in tarefas:
                print(f'{tarefa.id} - {tarefa.titulo} - Concluída: {tarefa.concluido}')
        elif opcao == '3':
            os.system('cls')
            id = input("Digite o ID da tarefa que deseja concluir: ")
            concluir_tarefa(id)
            print("Tarefa concluída com sucesso!")
        elif opcao == '4':
            os.system('cls')
            id = input("Digite o ID da tarefa que deseja remover: ")
            remover_tarefa(id)
            print("Tarefa removida com sucesso!")
        elif opcao == '0':
            break
        else:
            print("Opção inválida!")
    
if __name__ == '__main__':
    main()
    