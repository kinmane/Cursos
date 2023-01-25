const pessoa = {
    nome: 'Gabriel',
    sobrenome: 'Souza',
    idade: '24'
};

for (let chave in pessoa) {
  console.log(chave, ':', pessoa[chave]);
}

// for (let i = 0; i < frutas.length; i++) {
//     console.log(frutas[i]);
// }
