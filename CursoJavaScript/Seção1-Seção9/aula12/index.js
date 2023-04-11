let varA = 'A';
let varB = 'B';
let varC = 'C';

console.log(varA, varB, varC);

/*
Trocar os valores:
A vai ter o valor de B
B vai ter o valor de C
C vai ter o valor de A
*/

let = varATemp = varA;
varA = varB;
varB = varC;
varC = varATemp;

console.log(varA, varB, varC);

/*Outra forma de fazer

[varA, varB, varC] = [varB, varC, varA]

*/