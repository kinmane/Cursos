"""
13. Ler um número inteiro (assuma até três dígitos)
e imprimir a saída da seguinte forma:
CENTENA = x
DEZENA = x
UNIDADE = x
"""

num = int(input("Digite um número inteiro de até 3 dígitos: "))
centena = num // 100
dezena = (num % 100) // 10
unidade = (num % 100) % 10

print(f"CENTENA = {centena}")
print(f"DEZENA = {dezena}")
print(f"UNIDADE = {unidade}")
