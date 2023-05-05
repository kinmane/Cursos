/*
6. O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a
balança já desconte o peso do prato.
 */

const price = 12;
const weight = 0.5;

const payment = price * weight;

console.log(`O valor a pagar é de R$${payment}.`);
