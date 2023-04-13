"""
19) Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada 
lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é 
eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso 
contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a 
ocorrência.
"""

a = float(input("Digite o valor do lado A: "))
b = float(input("Digite o valor do lado B: "))
c = float(input("Digite o valor do lado C: "))

if a >= b + c or b >= a + c or c >= a + b:
    print("Os valores fornecidos não caracterizam um triângulo.")
else:
    if a == b and b == c:
        print("O triângulo é equilátero.")
    elif a == b or a == c or b == c:
        print("O triângulo é isósceles.")
    else:
        print("O triângulo é escaleno.")
