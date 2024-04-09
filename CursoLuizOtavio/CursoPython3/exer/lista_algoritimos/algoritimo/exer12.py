"""
12. Faça um algoritmo para ler o salário de um funcionário e aumentá-Io em 15%.
Após o aumento, desconte 8% de impostos. Imprima o salário inicial,
o salário com o aumento e o salário final.
"""

salary = float(input("Digite o salário do funcionário: "))
salary_increase = salary * 0.15
tax = salary_increase * 0.08
salary_final = salary_increase - tax

print("Salário inicial: ", salary)
print("Salário com aumento: ", salary_final)
print("Salário final: ", salary_final)
