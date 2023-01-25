// Produto -> aumento, desconto
// Camiseta = cor
// Caneca = material
function Produto(nome, preco) {
    this.nome = nome;
    this.preco = preco;
}

Produto.prototype.aumento = (quantia => this.preco += quantia);
Produto.prototype.desconto = (quantia => this.preco -= quantia);

function Camiseta(nome, preco, cor) {
    Produto.call(this, nome, preco);
    this.cor = cor;
}

Camiseta.prototype = Object.create(Produto.prototype);
Camiseta.prototype.constructor = Camiseta;

const produto = new Produto('Gen', 111);
const camiseta = new Produto('Manga Curta', 89.9, 'Preta');

console.log(produto);
console.log(camiseta);