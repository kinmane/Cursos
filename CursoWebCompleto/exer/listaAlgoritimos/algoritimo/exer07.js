/*
7. Entrar com o dia e o mês de uma data e informar quantos dias se passaram desde o início do
ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias.
 */

const day = 10;
const month = 3;

const days = (month - 1) * 30 + day;

console.log(`Desde o início do ano se passaram ${days} dias.`);
