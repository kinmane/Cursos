"""
3- Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:
1.Álcool 2.Gasolina 3.Diesel 4.Fim).
Caso o usuário informe um código inválido (fora da faixa de 1 a 4)
deve ser solicitado um novo código (até que seja válido).
O programa será encerrado quando o código informado for o número 4.
Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes
que abasteceram cada tipo de combustível.
"""

alcohol = 0
gasoline = 0
diesel = 0

while True:
    print("Digite o código do combustível:")
    print("1 - Álcool")
    print("2 - Gasolina")
    print("3 - Diesel")
    print("4 - Fim")
    code = int(input())

    if code == 1:
        alcohol += 1
    elif code == 2:
        gasoline += 1
    elif code == 3:
        diesel += 1
    elif code == 4:
        break
    else:
        print("Código inválido. Por favor, digite um código válido.")

print("MUITO OBRIGADO")
print("Álcool: ", alcohol)
print("Gasolina: ", gasoline)
print("Diesel: ", diesel)
