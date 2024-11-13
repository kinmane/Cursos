/*
 * 10) Escreva um algoritmo que leia um valor inicial A 
 * e imprima a seqüência de valores do cálculo de
 * A! e o seu resultado. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
 */

namespace Exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, f;

            System.Console.Write("Digite o valor inicial: ");
            a = int.Parse(System.Console.ReadLine());

            f = 1;
            for (i = a; i > 0; i--)
            {
                System.Console.Write("{0} ", i);
                f *= i;
                if (i > 1)
                    System.Console.Write("X ");
            }
            System.Console.WriteLine("= {0}", f);
        }
    }
}