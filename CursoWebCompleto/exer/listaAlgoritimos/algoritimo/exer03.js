/*
3. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a
cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber
quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de
poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com
base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular
os dados solicitados.
 */

const bread = 0.12;
const broa = 1.50;

const breadQuantity = 100;
const broaQuantity = 50;

const totalBread = bread * breadQuantity;
const totalBroa = broa * broaQuantity;

const total = totalBread + totalBroa;
const savings = total * 0.1;

console.log(`O total arrecadado foi de R$ ${total.toFixed(2)}`);
console.log(`O total a ser guardado na poupança é de R$ ${savings.toFixed(2)}`);
