"""
3) Faça um programa para pagamento de comissão de vendedores de peças, 
levando-se em consideração que sua 
comissão será de 5% do total da venda e que você tem os seguintes dados: 
- Identificação do vendedor 
- Código da peça 
- Preço unitário da peça 
- Quantidade vendida 
"""

id = int(input("Identificação do vendedor: "))
cod = int(input("Código da peça: "))
price = float(input("Preço unitário da peça: "))
qty_sold = int(input("Quantidade vendida: "))

commission = (qty_sold * price) * 0.05

print(f"Total vendido: R$ {qty_sold * price:.2f}")
print(f"Comissão do vendedor {id} é: {commission}")
