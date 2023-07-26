"""
36. Faça um algoritmo que receba o valor do salário mínimo
e o valor do salário de um funcionário,
calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.
"""

salary_min = float(input("Digite o valor do salário mínimo: "))
salary = float(input("Digite o valor do salário: "))

print(f"O funcionário ganha {salary / salary_min:.2f} salários mínimos")
