function semRetorno(...args: string[]): void {
  console.log(args.join(" "));
}

const pessoa = {
  nome: "Gabriel",
  sobrenome: "Souza",

  exibirNome(): void {
    console.log(this.nome + " " + this.sobrenome);
  },
};

semRetorno("Gabriel", "Souza");
pessoa.exibirNome();

export { pessoa };
