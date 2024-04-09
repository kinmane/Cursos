const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9];

for (let numero in numeros) {
    if (numero === 2) {
        // 'Continue' continua para próxima iteração
        continue;
    }

    if (numero === 7) {
        // Break sai do laço 
        break;
    }

    console.log(numero);
}