"""
35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10". 
"""

for num in range(1, 101):
    if num % 10 == 0:
        print(f"{num} Multiplo de 10")
    else:
        print(num)
