namespace Produto
{
    public class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Produto p = new Produto();
            
            System.Console.WriteLine("Entre os dados do produto:");
            System.Console.Write("Nome: ");
            p.Name = System.Console.ReadLine();
            System.Console.Write("Preço: ");
            p.Price = double.Parse(System.Console.ReadLine());
            System.Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados do produto: " + p);
            
            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(System.Console.ReadLine());
            p.AddProducts(quantidade);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);
            
            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(System.Console.ReadLine());
            p.RemoveProducts(quantidade);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);
        }
    }
}