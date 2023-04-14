"""
39. João recebeu seu salário de R$ 1200,00 e precisa pagar duas contas
(C1=R$ 200,00 e C2=R$120,00) que estão atrasadas.
Como as contas estão atrasadas, João terá de pagar multa de
2% sobre cada conta. Faça um algoritmo que calcule e
mostre quanto restará do salário do João
"""

bill1 = 200 + (200 * 0.02)
bill2 = 120 + (120 * 0.02)
salary = 1200 - (bill1 + bill2)

print(f"O valor restante do salário de João é de R$ {salary:.2f}")
