/*
9. Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo
vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo em que o usuário forneça a
quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e a máquina
informe quanto será o valor arrecadado.
 */

small = 10
medium = 12
large = 15

smallQuantity = 2
mediumQuantity = 3
largeQuantity = 4

total = (small * smallQuantity) + (medium * mediumQuantity) + (large * largeQuantity)

console.log(`O valor total arrecadado foi de R$ ${total}`)
