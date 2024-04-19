const nome = 'Gabriel';
const sobrenome = 'Souza';
const idade = 23;
const peso = 69;
const alturaEmMetros = 1.69;
let imc;
let anoNascimento;

imc = peso / (alturaEmMetros * alturaEmMetros);
anoNascimento = 2021 - idade

console.log(nome, sobrenome, 'tem', idade, 'anos, pesa', peso, 'Kg')
console.log(`Tem ${alturaEmMetros} de altura e seu IMC é de ${imc}`);
console.log(nome + ' nasceu em ' + anoNascimento + '.');
