"""
38. Faça um algoritmo que receba o ano de nascimento de uma pessoa
e o ano atual, calcule e mostre:
a) a idade dessa pessoa em anos;
b) a idade dessa pessoa em meses;
c) a idade dessa pessoa em dias;
d) a idade dessa pessoa em semanas.
"""

year_birth = int(input("Digite o ano de nascimento: "))
year_now = int(input("Digite o ano atual: "))

age = year_now - year_birth

print(f"A idade dessa pessoa em anos é {age}")
print(f"A idade dessa pessoa em meses é {age * 12}")
print(f"A idade dessa pessoa em dias é {age * 365}")
print(f"A idade dessa pessoa em semanas é {age * 52}")
