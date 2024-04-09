/*
5. Fazer um programa para ler o código de uma peça 1, o número de peças 1,
o valor unitário de cada peça 1, o código de uma peça 2,
o número de peças 2 e o valor unitário de cada peça 2.
Calcule e mostre o valor a ser pago.
 */

const code1 = 1234;
const qty1 = 20;
const price1 = 12.50;
const code2 = 4321;
const qty2 = 10;
const price2 = 35.50;

const totalValue = qty1 * price1 + qty2 * price2;

console.log(`Total da peça ${code1} e ${code2} é de R$${totalValue.toFixed(2)}`)