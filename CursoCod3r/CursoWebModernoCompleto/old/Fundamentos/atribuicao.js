// Atribuição por referencia
const a = { name: 'Teste' };
console.log(a);

const b = a;

b.name = 'Opa';

console.log(a);

// Atribuíção por valor
let c = 3;
let d = c;
d++;
console.log(c);
console.log(d);