"""
2- Escreva um programa para ler as coordenadas (X,Y)
de uma quantidade indeterminada de pontos no sistema cartesiano.
Para cada ponto escrever o quadrante a que ele pertence.
O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA
(nesta situação sem escrever mensagem alguma).
"""

while True:
    x = int(input("Digite a coordenada X (ou 0 para sair): "))
    y = int(input("Digite a coordenada Y (ou 0 para sair): "))

    if x == 0 or y == 0:
        break

    if x > 0 and y > 0:
        print("O ponto está no primeiro quadrante.")
    elif x < 0 < y:
        print("O ponto está no segundo quadrante.")
    elif x < 0 > y:
        print("O ponto está no terceiro quadrante.")
    elif x > 0 > y:
        print("O ponto está no quarto quadrante.")
    else:
        print("O ponto está na origem.")
