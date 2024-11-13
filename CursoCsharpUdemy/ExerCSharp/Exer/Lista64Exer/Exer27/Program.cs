/*
 * 27) Escreva um programa que leia:
 * - a quantidade de números que deverá processar;
 * - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
 * Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 
 */

namespace Exer27
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int fatorial = 1;
            int i = 0;

            System.Console.Write("Digite a quantidade de números que deverá processar: ");
            n = int.Parse(System.Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                System.Console.Write("Digite o {0}º número: ", i);
                fatorial = int.Parse(System.Console.ReadLine());

                for (int j = fatorial - 1; j > 0; j--)
                {
                    fatorial *= j;
                }

                System.Console.WriteLine("O fatorial de {0} é {1}", i, fatorial);
            }
        }
    }
}