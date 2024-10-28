/*
 * 3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
 * comissão será de 5% do total da venda e que você tem os seguintes dados:
 * - Identificação do vendedor
 * - Código da peça
 * - Preço unitário da peça
 * - Quantidade vendida
 */

namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sellerId, pieceCode, qtySold;
            double piecePrice, totalValue, commission;
            
            Console.WriteLine("Digite a identificação do vendedor: ");
            sellerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da peça: ");
            pieceCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça: ");
            piecePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            qtySold = int.Parse(Console.ReadLine());
            
            totalValue = qtySold * piecePrice;
            commission = totalValue * 0.05;
            
            Console.WriteLine("O valor total é: " + totalValue);
            Console.WriteLine("A comissão é: " + commission);
        }
    }
}