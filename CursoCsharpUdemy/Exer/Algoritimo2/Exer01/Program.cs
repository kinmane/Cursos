/*
 * 1) Faça um algoritmo que leia os valores A, B, C 
 * e imprima na tela se a soma de A + B é menor que C. 
 */

namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe os valores inteiros de A, B e C: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a + b) > c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else if((a + b) < c)
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é igual a C");
            }
        }
    }
}