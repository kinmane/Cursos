/*
8. Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir a sua média
ponderada (as notas tem pesos respectivos de 1, 2 e 3).
 */

const grade1 = 10;
const grade2 = 10;
const grade3 = 10;

const weight1 = 1;
const weight2 = 2;
const weight3 = 3;

const average = (grade1 * weight1 + grade2 * weight2 + grade3 * weight3) / (weight1 + weight2 + weight3);

console.log(`A média ponderada é ${average}`);
