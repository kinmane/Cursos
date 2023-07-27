"""
4- Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
o valor que recebe por hora e calcula o salário desse funcionário.
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
"""

id_employee = int(input("Informe o ID do funcionário: "))
worked_hours = float(input("Informe a quantidade de horas trabalhadas: "))
per_hour = float(input("Informe quanto recebe por hora trabalhada: "))

salary = worked_hours * per_hour

print("Funcionário", id_employee)
print("Seu sálario será de R$", salary)
