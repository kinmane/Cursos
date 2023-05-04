"""
11) Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço
normal deetiqueta e a escolha da condição de pagamento. Utilize os códigos da tabela a seguir
para ler qual acondição de pagamento escolhida e efetuar o cálculo adequado.
Código Condição de pagamento

1 À vista em dinheiro ou cheque, recebe 10% de desconto
2 À vista no cartão de crédito, recebe 15% de desconto
3 Em duas vezes, preço normal de etiqueta sem juros
4 Em duas vezes, preço normal de etiqueta mais juros de 10%
"""

valor = float(input('Digite o valor do produto: '))
print('1 - À vista em dinheiro ou cheque, recebe 10% de desconto')
print('2 - À vista no cartão de crédito, recebe 15% de desconto')
print('3 - Em duas vezes, preço normal de etiqueta sem juros')
print('4 - Em duas vezes, preço normal de etiqueta mais juros de 10%')
condicao = int(input('Digite a condição de pagamento: '))

if condicao == 1:
    valor = valor - (valor * 0.1)
elif condicao == 2:
    valor = valor - (valor * 0.15)
elif condicao == 3:
    valor = valor / 2
elif condicao == 4:
    valor = (valor + (valor * 0.1)) / 2
else:
    print('Condição inválida')

print(f'Valor a pagar: {valor}')
