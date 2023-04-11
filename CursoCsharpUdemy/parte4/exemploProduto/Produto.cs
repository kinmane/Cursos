using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exemploProduto
{
    public class Produto
    {
        public string Name;
        public double Price;
        public int Qty;

        public double TotalValue()
        {
            return Price * Qty;
        }

        public void AddQty(int qty)
        {
            Qty += qty;
            Console.WriteLine("Quantidade adicionada");
            Console.WriteLine("Quantidade nova: " + Qty);
        }

        public void RemoveQty(int qty)
        {
            Qty -= qty;
            Console.WriteLine("Quantidade removida");
            Console.WriteLine("Quantidade nova: " + Qty);
        }
    }
}