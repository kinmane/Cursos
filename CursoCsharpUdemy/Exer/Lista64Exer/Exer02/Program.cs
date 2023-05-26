/*
 * 2) Faça um programa que:
 * - Leia a cotação do dólar
 * - Leia um valor em dólares
 * - Converta esse valor para Real
 * - Mostre o resultado 
 */

namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dólar: ");
            double dolarQuote = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólares: ");
            double dolarValue = double.Parse(Console.ReadLine());
            
            double realValue = dolarValue * dolarQuote;
            
            Console.WriteLine("O valor em reais é: " + realValue);
        }
    }
}