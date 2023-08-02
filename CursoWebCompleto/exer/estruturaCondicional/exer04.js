/*
4. Leia a hora inicial e a hora final de um jogo.
A seguir calcule a duração do jogo,
sabendo que o mesmo pode começar em um dia e terminar em outro,
tendo uma duração mínima de 1 hora e máxima de 24 horas.
 */

const startTime = 10;
const endTime = 12;

if (startTime < endTime) {
    console.log(`O jogo durou ${endTime - startTime} horas`);
} else {
    console.log(`O jogo durou ${24 - startTime + endTime} horas`);
}
