let num1 = 1; // number
let num2 = 2.5; // number

console.log(num1.toString() + num2); // altera o tipo do num1 apenas nessa linha para string, usando o typeof na linha de baixo, da pra ver que continua number
// num1 = num1.toString(); // aqui ele acaba alterando de vez o tipo da variavel
console.log(typeof num1); // aqui mostra que realmente não alterou a variavel por completo, apenas na linha de cima.
console.log(num1.toString(2)); // aqui ele vai colocar na forma binaria.
console.log(num1.toFixed(2)); // quebra na quantidade pedida nas casas decimais, no caso mostra apenas duas.
console.log(Number.isInteger(num1)); // retorna true or false, pra se for inteiro ou não a variavel.