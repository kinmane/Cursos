/*
 * 9. Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo
 * vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo em que o usuário forneça a
 * quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e a máquina
 * informe quanto será o valor arrecadado. 
 */

namespace Exer09
{
    public class Program
    {
        static void Main(string[] args)
        {
            int smallAmount, mediumAmount, largeAmount, total;
            
            int small = 10;
            int medium = 12;
            int large = 15;

            System.Console.Write("Quantidade de camisetas pequenas: ");
            smallAmount = int.Parse(System.Console.ReadLine());

            System.Console.Write("Quantidade de camisetas médias: ");
            mediumAmount = int.Parse(System.Console.ReadLine());

            System.Console.Write("Quantidade de camisetas grandes: ");
            largeAmount = int.Parse(System.Console.ReadLine());

            total = (small * smallAmount) + (medium * mediumAmount) + (large * largeAmount);

            System.Console.WriteLine($"Total arrecadado: {total}");
        }
    }
}