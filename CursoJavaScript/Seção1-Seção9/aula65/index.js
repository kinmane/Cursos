// Exemplo 1

// const numeros = [5, 50, 80, 1, 2, 3, 5, 8, 7, 11, 22, 27];

// const numerosFiltrados = numeros.filter(valor => valor > 10);

// console.log(numerosFiltrados);

// Exemplo 2

const pessoas = [
  { nome: 'Luiz', idade: 62},
  { nome: 'Maria', idade: 23},
  { nome: 'Eduardo', idade: 55},
  { nome: 'Letícia', idade: 19},
  { nome: 'Rosana', idade: 32},
  { nome: 'Wallace', idade: 47},
];

const pessoasNomeGrande = pessoas.filter(valor => valor.nome.length >= 5);
console.log(pessoasNomeGrande);
console.log('--------------------------');

const pessoasMaisCinquenta = pessoas.filter(valor => valor.idade > 50);
console.log(pessoasMaisCinquenta);
console.log('--------------------------');

const pessoasTerminaA = pessoas.filter(valor => valor.nome.toLowerCase().endsWith('a'));
console.log(pessoasTerminaA);