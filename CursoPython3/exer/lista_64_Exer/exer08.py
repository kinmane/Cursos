"""
8) Calcular e apresentar o valor do volume de uma lata de óleo, 
utilizando a fórmula: 
V = 3.14159 * R * R * A 
Onde as variáveis: V, R e A representam respectivamente o volume, 
o raio e a altura.
"""

radius = float(input('Informe o raio da lata de óleo: '))
height = float(input('Informe a altura da lata de óleo: '))

volume = 3.14159 * radius * radius * height

print(f'O volume de uma lata de óleo é: {volume:.2f}')
