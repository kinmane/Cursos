/*
 * 8) Escreva um algoritmo que leia três valores inteiros 
 * e diferentes e mostre-os em ordem decrescente. 
 */

namespace Exer08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", c, b, a);
                }
            }
        }
    }
}