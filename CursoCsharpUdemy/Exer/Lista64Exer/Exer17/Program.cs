/*
 * 17) Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
 * entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
 * Caso contrário, apresentar a mensagem “valor inválido”. 
 */

namespace Exer17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}