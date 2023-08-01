/*
9. Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
calcule seu peso ideal, utilizando as seguintes fórmulas:
● para homens: (72.7 * h) – 58;
● para mulheres: (62.1 * h) – 44.7.
 */

const height = 1.70;
const sex = 'M';

if (sex === 'M') {
  console.log((72.7 * height) - 58);
} else {
  console.log((62.1 * height) - 44.7);
}
