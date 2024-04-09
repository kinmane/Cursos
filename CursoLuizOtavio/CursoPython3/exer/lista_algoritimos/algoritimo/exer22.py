"""
22. Pedrinho tem um cofrinho com muitas moedas,
e deseja saber quantos reais conseguiu poupar.
Faça um algoritmo para ler a quantidade de cada tipo de moeda,
e imprimir o valor total economizado, em reais.
Considere que existam moedas de 1, 5, 10, 25 e 50 centavos,
e ainda moedas de 1 real. Não havendo moeda de um tipo,
a quantidade respectiva é zero.
"""

coin_01 = int(input("Quantas moedas de 1 centavo você tem? "))
coin_05 = int(input("Quantas moedas de 5 centavos você tem? "))
coin_10 = int(input("Quantas moedas de 10 centavos você tem? "))
coin_25 = int(input("Quantas moedas de 25 centavos você tem? "))
coin_50 = int(input("Quantas moedas de 50 centavos você tem? "))
coin_1 = int(input("Quantas moedas de 1 real você tem? "))

total = coin_01 * 0.01 + coin_05 * 0.05 + coin_10 * 0.10 + coin_25 * 0.25 + coin_50 * 0.50 + coin_1 * 1

print(f"Você guardou {total} reais")
