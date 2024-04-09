"""
6) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão de 
temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus 
Fahrenheit e a variável C representa é a temperatura em graus Celsius.
"""

celsius = float(input("Informe a temperatura em Celsius: "))

fahrenheit = (9 * celsius + 160) / 5

print("Temperatura em Fahrenheit: ", fahrenheit)
