/*
6. Fazer um programa que leia três valores com ponto flutuante de dupla precisão:
A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
 */

const a = 12.34;
const b = 43.21;
const c = 23.14;

const triangle = a * c / 2;
const circle = 3.14159 * Math.pow(c, 2);
const trapezium = (a + b) * c / 2;
const square = b * b;
const rectangle = a * b;

console.log('Triangle: ' + triangle.toFixed(2));
console.log('Circle: ' + circle.toFixed(2));
console.log('Trapezium: ' + trapezium.toFixed(2));
console.log('Square: ' + square.toFixed(2));
console.log('Rectangle: ' + rectangle.toFixed(2));