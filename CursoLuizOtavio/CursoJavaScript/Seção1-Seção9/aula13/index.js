//               01234567
let umaString = "Um texto";

console.log(umaString[4]); // não pode sair do range da string, da erro.
console.log(umaString.charAt(6)); // pode sair do range, não da erro, apenas não mostra nada.

console.log(umaString.concat(' em', ' um', ' lindo dia.'));
console.log(umaString + ' em um lindo dia.');
console.log(`${umaString} em um lindo dia`);

console.log(umaString.indexOf('texto')); // mostra 3, pois é onde a string 'texto' começa.
console.log(umaString.lastIndexOf('o')); // começa a buscar de tras pra frente.

console.log(umaString.match(/[a-z]/g)); // expressão regular.
console.log(umaString.replace('Um', 'Outra')); // troca o item 1 pelo 2.

let outraString = 'O rato roeu a roupa do rei de roma';
console.log(outraString.replace(/r/g, '#')); // se não colocar o 'g' após a expressão regular / /  ele substitui apenas o primeiro

console.log(outraString.length); // tamanho da string

console.log(outraString.slice(2, 6)); // pega exatamente o range solicitado, no exemplo vai do 2 até o 5, pois é 6 -1, se não não pega o ultimo, no caso não pegaria 'rato' e sim 'rat'.

console.log(outraString.split(' ')); // divide a string em arrays, após a virgula é o tanto de resultado que ira mostrar, caso não coloque, ele divide exatamente onde foi solicitado, como no exemplo, nos espaços.

console.log(outraString.toUpperCase()); // coloca toda a string em UpperCase
console.log(outraString.toLowerCase()); // coloca toda a string em LowerCase
