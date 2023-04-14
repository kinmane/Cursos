"""
40. Faça um algoritmo que receba o valor dos catetos de um triângulo, calcule e mostre o valor da
hipotenusa.
"""

leg1 = float(input("Digite o valor do primeiro cateto: "))
leg2 = float(input("Digite o valor do segundo cateto: "))

hypotenuse = (leg1**2 + leg2**2)**0.5

print("O valor da hipotenusa é: ", hypotenuse)

