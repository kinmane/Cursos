const alunos = ['Luiz', 'Maria', 'João'];

console.log(alunos); //Array completo.
console.log(alunos[0]); //Indice 0 do Array (Luiz).
console.log(alunos[2]); //Indice 0 do Array (João).

alunos[0] = 'Eduardo'; //Trocando o indice 0 de Luiz para Eduardo.
alunos[3] = 'Luiza'; //Cria o indece 3 com Luiza, só funciona dessa forma se tu já souber o tamanho, se não rodar leigth.

console.log(alunos);
console.log(alunos.length); //Tamanho do Array.

alunos[alunos.length] = 'Gustavo'; //Adicona no fim do Array

alunos.push('Otavio'); //Adiciona no Array no fim.

alunos.unshift('Gabriel'); //Adiciona no primeiro indice.

alunos.pop(); //Remove o ultimo indice, pode ser salvo em uma variavel.
alunos.shift(); //Remove o primeiro indice, pode ser salvo em uma variavel.
