/*
5. Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o
preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no
tanque.
 */

const price = 5.5;
const payment = 100;

const liters = payment / price;

console.log(`O motorista conseguiu colocar ${liters} litros de gasolina no tanque.`);
