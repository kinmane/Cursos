/*
3. Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
 */

const a = 10;
const b = 15;

if (a % b === 0 || b % a === 0) {
    console.log("São múltiplos");
} else {
    console.log("Não são múltiplos");
}