"""
19. A granja Frangotech possui um controle automatizado de cada frango
da sua produção. No pé direito do frango há um anel
com um chip de identificação; no pé esquerdo
são dois anéis para indicar o tipo de alimento
que ele deve consumir.
Sabendo que o anel com chip custa R$4,00 e o
anel de alimento custa R$3,50,
faça um algoritmo para calcular o gasto total da granja para marcar
todos os seus frangos.
"""

qty = int(input("Quantos frangos tem na granja? "))

cost_chicken = 4 + 2 * 3.5
cost_total = qty * cost_chicken

print(f"O custo total para marcar todos os frangos é de R${cost_total:.2f}")
