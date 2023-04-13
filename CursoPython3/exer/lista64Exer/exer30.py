"""
30) Faça um programa para imprimir uma tabuada. 
"""

for row in range(1, 11):
    for column in range(1, 11):
        result = row * column
        print(f"{row} x {column} = {result}")
    print()
