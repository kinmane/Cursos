/*
 * Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
 * uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
 * que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
 * para ser responsável pelos cálculos.
 */

namespace ExerPropostoMembrosEstaticos
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cotacao, valor, resultado;
            
            System.Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(System.Console.ReadLine());

            System.Console.Write("Quantos dólares você vai comprar? ");
            valor = double.Parse(System.Console.ReadLine());

            resultado = ConversorDeMoeda.DolarParaReal(cotacao, valor);

            System.Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2"));                        
        }
    }
}