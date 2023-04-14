"""
18. A empresa Hipotheticus paga R$10,00 por hora normal trabalhada, e R$15,00 por hora extra.
Faça um algoritmo para calcular e imprimir o salário bruto e o salário líquido de um determinado
funcionário. Considere que o salário líquido é igual ao salário bruto descontando-se 10% de
impostos.
"""

hour = float(input("Digite a quantidade de horas trabalhadas: "))
hour_extra = float(input("Digite a quantidade de horas extras trabalhadas: "))

salary = (hour * 10) + (hour_extra * 15)
salary_tax = salary * 0.1
salary_net = salary - salary_tax

print("O salário bruto é: R$", salary)
print("O salário líquido é: R$", salary_net)
