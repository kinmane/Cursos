namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        
        public Produto()
        {
        }

        public Produto(string nome,double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                   + ", $ "
                   + Preco.ToString("F2")
                   + ", "
                   + _quantidade
                   + " unidades, Total: R$"
                   + ValorTotalEmEstoque().ToString("F2");
        }
    }
}