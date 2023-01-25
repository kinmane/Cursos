function criaPessoa(nome, sobrenome, a, p) {
  return {
    nome,
    sobrenome,
    get nomeCompleto() {
      return `${this.nome} ${this.sobrenome}`;
    },
    set nomeCompleto(valor) {
      valor = valor.split(' ');
      this.nome = valor.shift();
      this.sobrenome = valor.join();
    },
    fala(assunto) {
      return `${this.nome} está ${assunto}.`;
    },
    altura: a,
    peso: p,
    get imc() {
      const indice = this.peso / this.altura ** 2;
      return indice.toFixed(2);
    },
  };
}

const p1 = criaPessoa("Gabriel", "Souza", 1.7, 70);
p1.nomeCompleto = "Luiz Miranda";
console.log(p1.nome);
console.log(p1.sobrenome);