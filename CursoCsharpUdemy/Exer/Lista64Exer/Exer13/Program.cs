/*
 * 13) Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.
 */

namespace Exer13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
                }
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
                }
            }
            else
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
                }
            }
        }
    }
}