/*
 * 7) Faça um algoritmo que leia uma variável e some 5 caso seja par ou some 8 caso seja ímpar,
 * imprimir o resultado desta operação. 
 */

namespace Exer07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par, somando 5 fica {1}", num, num + 5);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar, somando 8 fica {1}", num, num + 8);
            }
        }
    }
}