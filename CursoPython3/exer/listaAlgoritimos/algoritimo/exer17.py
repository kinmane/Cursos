"""
17. Alguns países medem temperaturas em graus Celsius,
e outros em graus Fahrenheit.
Faça um algoritmo para ler uma temperatura Celsius
e imprimi-Ia em Fahrenheit (pesquise como fazer este tipo de conversão).
"""

celcius = float(input("Digite a temperatura em graus Celcius: "))
fahrenheit = (celcius * 1.8) + 32

print("A temperatura em graus Fahrenheit é: ", fahrenheit)