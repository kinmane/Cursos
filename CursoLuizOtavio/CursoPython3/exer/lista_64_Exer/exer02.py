"""
2) Faça um programa que: 
- Leia a cotação do dólar 
- Leia um valor em dólares 
- Converta esse valor para Real 
- Mostre o resultado 
"""

exchange_rate = float(input("Digite a cotação atual do dólar: "))
dollar_value = float(input("Digite o valor que você quer converter: "))

real_value = dollar_value * exchange_rate

print("O valor convertido para real é R$ {:.2f}".format(real_value))
