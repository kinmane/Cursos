/*
 * 20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
 * variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido
 * multiplicado pelo maior e o maior valor dividido pelo menor. 
 */

namespace Exer20
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            do
            {
                Console.WriteLine("Digite o valor de A: ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.WriteLine("Digite o valor de B: ");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);

            do
            {
                Console.WriteLine("Digite o valor de C: ");
                c = int.Parse(Console.ReadLine());
            } while (c <= 0);

            if (a < b && a < c)
            {
                Console.WriteLine("O menor valor é: " + a);
                Console.WriteLine("O maior valor é: " + (b > c ? b : c));
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("O menor valor é: " + b);
                Console.WriteLine("O maior valor é: " + (a > c ? a : c));
            }
            else
            {
                Console.WriteLine("O menor valor é: " + c);
                Console.WriteLine("O maior valor é: " + (a > b ? a : b));
            }
        }
    }
}