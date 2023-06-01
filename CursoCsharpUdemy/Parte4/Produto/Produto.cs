namespace Produto;

public class Produto
{
    public string Name;
    public double Price;
    public int Quantity;
    
    public double TotalValueInStock()
    {
        return Price * Quantity;
    }
    
    public void AddProducts(int quantity)
    {
        Quantity += quantity;
    }
    
    public void RemoveProducts(int quantity)
    {
        Quantity -= quantity;
    }
    
    public override string ToString()
    {
        return Name
            + ", $ "
            + Price.ToString("F2")
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2");
    }
}