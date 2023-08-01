/*
8. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem
decrescente.
 */

const value1 = 5;
const value2 = 10;
const value3 = 15;

if (value1 > value2 && value1 > value3) {
  if (value2 > value3) {
    console.log(value1, value2, value3);
  } else {
    console.log(value1, value3, value2);
  }
}