"""
20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada 
variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido 
multiplicado pelo maior e o maior valor dividido pelo menor. 
"""

a = -1
b = -1
c = -1

while a <= 0:
    a = int(input("Digite um valor inteiro maior que zero para a: "))

while b <= 0:
    b = int(input("Digite um valor inteiro maior que zero para b: "))

while c <= 0:
    c = int(input("Digite um valor inteiro maior que zero para c: "))

menor = min(a, b, c)
maior = max(a, b, c)

print("O menor valor lido multiplicado pelo maior é:", menor * maior)
print("O maior valor lido dividido pelo menor é:", maior / menor)
