"""
3- Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" 
ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. 
Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
"""

a = int(input("Digite o primeiro valor: "))
b = int(input("Digite o segundo valor: "))

if (a % b == 0 and b % a == 0):
    print("São Multiplos.")
else:
    print("Não São Multiplos.")
