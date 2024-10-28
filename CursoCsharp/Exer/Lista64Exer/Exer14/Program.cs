/*
 * 14) Escreva um programa que leia dois números e apresente a diferença do maior para o menor. 
 */

namespace Exer14
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            
            Console.WriteLine("Digite o primeiro número: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (firstNumber - secondNumber));
            }
            else
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (secondNumber - firstNumber));
            }
        }
    }
}