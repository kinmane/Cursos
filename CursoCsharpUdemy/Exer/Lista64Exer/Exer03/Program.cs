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
            Console.WriteLine("Digite a identificação do vendedor: ");
            int sellerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da peça: ");
            int pieceCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça: ");
            double piecePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            int qtySold = int.Parse(Console.ReadLine());
            
            double totalValue = qtySold * piecePrice;
            double commission = totalValue * 0.05;
            
            Console.WriteLine("O valor total é: " + totalValue);
            Console.WriteLine("A comissão é: " + commission);
        }
    }
}