/*
 * 6) Escreva um algoritmo que lê dois valores booleanos (lógicos) 
 * e então determina se ambos são VERDADEIROS ou FALSOS. 
 */

namespace Exer06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool a, b;

            Console.Write("Digite o valor de A: ");
            a = bool.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = bool.Parse(Console.ReadLine());

            if (a && b)
            {
                Console.WriteLine("A e B são verdadeiros");
            }
            else if (a || b)
            {
                Console.WriteLine("A ou B são verdadeiros");
            }
            else
            {
                Console.WriteLine("A e B são falsos");
            }
        }
    }
}