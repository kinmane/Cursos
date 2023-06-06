/*
 * 3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar. 
 */

namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Informe um número: ");
            num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}