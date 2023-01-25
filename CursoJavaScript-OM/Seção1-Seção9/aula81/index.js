const _velocidade = Symbol('velocidade');
class Carro {
    constructor(nome, velocidade) {
        this.nome = nome;
        this[_velocidade] = 0;
    }

    acelerar() {
        if(_velocidade > 100) return;
        this[_velocidade]++;
    }

    freiar() {
        if (this.velocidade < 0) return;
        this[_velocidade]--;
    }
}

const c1 = new Carro('Fusca');

for (let i = 0; i <= 200; i++) {
    c1.acelerar();    
}