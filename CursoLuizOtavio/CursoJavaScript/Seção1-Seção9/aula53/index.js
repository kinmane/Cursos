function retornaFuncao(nome) {
  return function () {
    return nome;
  };
}

const funcao = retornaFuncao('Gabriel');
const funcao2 = retornaFuncao('Souza');
console.dir(funcao);
console.dir(funcao2);

console.log(funcao(), funcao2());