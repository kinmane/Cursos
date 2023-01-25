function funcao() {
  let total = 0;
  for (const argumento of arguments) {
    total += argumento;
  }
  console.log(total)
}
funcao(1, 2, 3, 4, 5, 6, 7);