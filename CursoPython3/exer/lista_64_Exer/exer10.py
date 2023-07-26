"""
10) Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes 
entre eles. Os relacionamentos possíveis são: Igual, 
Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 
"""

num1 = int(input("Digite o primeiro número: "))
num2 = int(input("Digite o segundo número: "))

result = ((num1 == num2)
          and f"{num1} é igual a {num2}") or f"{num1} não é igual a {num2}"
print(result)

result = ((num1 > num2)
          and f"{num1} é maior do que {num2}") or f"{num1} não é maior do que {num2}"
print(result)

result = ((num1 < num2)
          and f"{num1} é menor do que {num2}") or f"{num1} não é menor do que {num2}"
print(result)

result = ((num1 >= num2)
          and f"{num1} é maior ou igual a {num2}") or f"{num1} não é maior ou igual a {num2}"
print(result)

result = ((num1 <= num2)
          and f"{num1} é menor ou igual a {num2}") or f"{num1} não é menor ou igual a {num2}"
print(result)
