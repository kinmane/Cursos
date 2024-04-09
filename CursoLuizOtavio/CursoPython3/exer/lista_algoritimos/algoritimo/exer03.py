"""
3. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a
cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber
quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de
poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com
base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular
os dados solicitados.
"""

bread = int(input("Digite a quantidade de pães: "))
cornbread = int(input("Digite a quantidade de broas: "))

total_price = bread * 0.12 + cornbread * 1.5
savings = total_price * 0.1

print("O valor que deve ser guardado na poupança é: ", savings)
