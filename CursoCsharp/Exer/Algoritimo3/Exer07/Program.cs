/*
 * 7) Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 
 * e calcule a tabuada de N. 
 * Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N. 
 */

namespace Exer07
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite um valor de 1 a 10:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + (i * n));
            }
        }
    }
}