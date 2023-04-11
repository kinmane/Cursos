/****************************************************************************
*   3) Faça um programa para pagamento de comissão de vendedores de peças,
*   levando-se em consideração que sua comissão será de 5% do total da venda
*   e que você tem os seguintes dados:
*   - Identificação do vendedor
*   - Código da peça
*   - Preço unitário da peça
*   - Quantidade vendida
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ID do vendedor: ");
            int sellerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da peça: ");
            int pieceCod = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço unitário da peça: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantidade de peça vendida: ");
            int qtySold = int.Parse(Console.ReadLine());

            double sales = qtySold * price;
            double commission = sales * 0.05;

            Console.WriteLine("ID: " + sellerId);
            Console.WriteLine("Código da peça: " + pieceCod);
            Console.WriteLine("Preço unitário: " + price);
            Console.WriteLine("Quantidade vendida: " + qtySold);
            Console.WriteLine("Valor vendido " + sales.ToString("F2"));
            Console.WriteLine("Comissão R$" + commission.ToString("F2"));
        }
    }
}