/*
 * 9) Escreva um algoritmo que leia um valor inicial A e uma razão R 
 * e imprima uma seqüência em P.G. contendo 10 valores. 
 */

namespace Exer09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, r, i;

            System.Console.Write("Digite o valor inicial: ");
            a = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a razão: ");
            r = int.Parse(System.Console.ReadLine());

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Termo {0}: {1}", i + 1, a);
                a *= r;
            }
        }
    }
}