"""
Repetições
while (enquanto)
Executa uma ação enquanto uma condição for verdadeira
Loop infinito -> Quando um código não tem fim
"""
condicao = True

while condicao:
    nome = input('Qual o seu nome: ')
    
    if nome == 'SAIR' or nome == 'Sair' or nome == 'sair':
        print('Saindo...')
    else:
        print(f'Seu nome é {nome}')

print('Acabou')
