namespace Produto;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    public double TotalValueInStock()
    {
        return Preco * Quantidade;
    }
    
    public void AddProducts(int quantidade)
    {
        Quantidade += quantidade;
    }
    
    public void RemoveProducts(int quantidade)
    {
        Quantidade -= quantidade;
    }
    
    public override string ToString()
    {
        return Nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2");
    }
}