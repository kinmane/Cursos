"""
7) Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. A fórmula de conversão de 
temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a 
variável C é a temperatura em graus Celsius. 
"""

fahrenheit = float(input("Informe a temperatura em Fahrenheit: "))

celsius = (fahrenheit - 32) * 5 / 9

print("Temperatura em Celsius: ", celsius)
