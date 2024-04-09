/*
10. Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada
ponto é um par ordenado (x,y).
 */

const x1 = 1;
const y1 = 2;
const x2 = 4;
const y2 = 6;

const distancia = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));

console.log(`A distância entre os pontos (${x1},${y1}) e (${x2},${y2}) é ${distancia}`);
