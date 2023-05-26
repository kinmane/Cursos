/*
 * 10) Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
 * entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 
 */

namespace Exer10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Igual");
            }
            else
            {
                Console.WriteLine("Não igual");
            }

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Maior");
            }
            else
            {
                Console.WriteLine("Menor");
            }

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("Maior ou igual");
            }
            else
            {
                Console.WriteLine("Menor ou igual");
            }
        }
    }
}