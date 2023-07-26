"""
15. Três amigos, Carlos, André e Felipe.
decidiram rachar igualmente a conta de um bar.
Faça um algoritmo para ler o valor total da conta e imprimir
quanto cada um deve pagar, mas faça com que
Carlos e André não paguem centavos.
Ex: uma conta de R$101,53 resulta em R$33,00 para
Carlos, R$33,00 para André e R$35,53 para Felipe.
"""

bill = float(input("Digite o valor da conta: "))

print(f"Carlos deve pagar: R${(bill // 3):.2f}")
print(f"André deve pagar: R${(bill // 3):.2f}")
print(f"Felipe deve pagar: R${(bill - (bill // 3) * 2):.2f}")
