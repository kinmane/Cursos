/*
 * 8) Escreva um algoritmo que leia um valor inicial A e uma razão R 
 * e imprima uma seqüência em P.A. contendo 10 valores. 
 */

namespace Exer08
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, r;

            Console.WriteLine("Digite o valor inicial:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a razão:");
            r = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a + (i * r));
            }
        }
    }
}