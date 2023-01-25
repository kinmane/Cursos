type TemNome = { nome: string };
type TemSobrenome = { sobrenome: string };
type TemIdade = { idade: number };
type Pessoa = TemNome & TemSobrenome & TemIdade;

const pessoa: Pessoa = {
  nome: "Gabriel",
  sobrenome: "Souza",
  idade: 24,
};

console.log(pessoa);

export { pessoa };
