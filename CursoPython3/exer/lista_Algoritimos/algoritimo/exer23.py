"""
23. Num dia de sol, você deseja medir a altura de um prédio,
porém, a trena não é suficientemente longa.
Assumindo que seja possível medir sua sombra e a do prédio no chão,
e que você lembre da sua altura,
faça um algoritmo para ler os dados necessários e calcular a altura do prédio.
"""

height_observer = float(input("Digite a altura do observador: "))
shadow_building = float(input("Digite o comprimento da sombra do prédio: "))
shadow_observer = float(input("Digite o comprimento da sombra do observador: "))

height_building = height_observer * shadow_building / shadow_observer

print(f"A altura do prédio é {height_building:.2f}")
