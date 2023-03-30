using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exemploProduto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();

            Console.WriteLine("Entre com o nome do produto: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Entre com o preço do produto: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade do produto: ");
            product.Qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Total do produto: " + product.TotalValue().ToString("F2"));

            product.AddQty(2);
            product.RemoveQty(2);
        }
    }
}