/*
 * 16) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
 * menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato. 
 */

namespace Exer16
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
                Console.WriteLine("O maior número é: " + firstNumber);
                Console.WriteLine("O menor número é: " + secondNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("O maior número é: " + secondNumber);
                Console.WriteLine("O menor número é: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
    }
}