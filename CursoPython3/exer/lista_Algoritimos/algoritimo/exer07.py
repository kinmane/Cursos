"""
7. Entrar com o dia e o mês de uma data e informar quantos dias se passaram
desde o início do ano. Esqueça a questão dos anos bissextos
e considere sempre que um mês possui 30 dias.
"""

day = int(input("Digite o dia: "))
month = int(input("Digite o mês: "))

days_passed = (month - 1) * 30 + day

print(f"Já se passaram {days_passed} dias desde o início do ano.")
