/*
 * 12) Escreva um programa que leia um número inteiro e exiba o seu módulo.
 * O módulo de um número x é:
 * x se x é maior ou igual a zero
 * x * (-1) se x é menor que zero 
 */

namespace Exer12
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Digite um número: ");
            number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("O módulo do número é: " + number);
            }
            else
            {
                Console.WriteLine("O módulo do número é: " + (number * (-1)));
            }
        }
    }
}