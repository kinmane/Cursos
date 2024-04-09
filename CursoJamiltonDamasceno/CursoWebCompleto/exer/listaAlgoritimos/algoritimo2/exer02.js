/*
2. Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.
Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).
 */

const name = 'Maria';
const sex = 'F';
const civilState = 'CASADA';

if (sex === 'F' && civilState === 'CASADA') {
  const timeMarried = 5;
  console.log(`${name} está casada há ${timeMarried} anos`);
}