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
            double dolarQuote, dolarValue, realValue;
            
            Console.WriteLine("Digite a cotação do dólar: ");
            dolarQuote = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólares: ");
            dolarValue = double.Parse(Console.ReadLine());
            
            realValue = dolarValue * dolarQuote;
            
            Console.WriteLine("O valor em reais é: " + realValue);
        }
    }
}