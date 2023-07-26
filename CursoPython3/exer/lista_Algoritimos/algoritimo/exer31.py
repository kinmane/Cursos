"""
31. Faça um algoritmo que receba o peso de uma pessoa, calcule e mostre:
a) o novo peso se a pessoa engordar 15% sobre o peso digitado;
b) o novo peso se a pessoa emagrecer 20% sobre o peso digitado.
"""

weight = float(input("Digite o peso da pessoa: "))

weight_gain = weight + (weight * 0.15)
weight_loss = weight - (weight * 0.20)

print(f"O novo peso ganhando 15% é: {weight_gain}")
print(f"O novo peso perdendo 20% é: {weight_loss}")
