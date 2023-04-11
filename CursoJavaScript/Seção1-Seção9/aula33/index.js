const pessoa = {
  nome: "Gabriel",
  sobrenome: "Souza",
  idade: 24,
  endereco: {
    rua: "Rua Tupa",
    numero: 20,
  },
};

const {
  endereco: { rua, numero },
  endereco,
} = pessoa;
console.log(rua, numero);
console.log(endereco);
