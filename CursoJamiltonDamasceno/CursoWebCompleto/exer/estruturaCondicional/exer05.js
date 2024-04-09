/*
5. Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem
dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100])
este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
 */

const value = 10;

if (value >= 0 && value <= 25) {
  console.log("O valor está no intervalo [0, 25].");
} else if (value > 25 && value <= 50) {
  console.log("O valor está no intervalo (25, 50].");
} else if (value > 50 && value <= 75) {
  console.log("O valor está no intervalo (50, 75].");
} else if (value > 75 && value <= 100) {
  console.log("O valor está no intervalo (75, 100].");
} else {
  console.log("Fora de intervalo.");
}
