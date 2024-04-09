"""
15) Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi 
aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota 
do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7, 
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, 
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do 
aluno.
"""

grade1 = float(input('Digite a primeira nota: '))
grade2 = float(input('Digite a seunga nota: '))
grade3 = float(input('Digite a terceira nota: '))
grade4 = float(input('Digite a quarta nota: '))

average = (grade1 + grade2 + grade3 + grade4) / 4

if (average >= 7):
    print('O aluno foi aprovado na recuperação')
    print(f'Sua média é {average}')
else:
    print('Prova de recuperação')
    new_grade = int(input('Digite a nova nota: '))
    new_average = (new_grade + average) / 2

    if (new_average >= 7):
        print('O aluno foi aprovado na recuperação')
        print(f'Sua média é {new_average}')
    else:
        print('Reprovado')
