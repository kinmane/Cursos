(function (idade, peso, altura) {
  
  const sobrenome = "Souza";
  function criaNome(nome) {
    return nome + " " + sobrenome;
  }

  function falaNome() {
    console.log(criaNome("Gabriel"));
  }

  falaNome();
  console.log(idade, peso, altura);

})(24, 70, 1.70);
