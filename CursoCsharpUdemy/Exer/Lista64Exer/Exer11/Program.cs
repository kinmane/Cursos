﻿/*
 * 11) Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
 * possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
 */

namespace Exer11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int aux = firstNumber;
            firstNumber = secondNumber;
            secondNumber = aux;

            Console.WriteLine("O primeiro número é: " + firstNumber);
            Console.WriteLine("O segundo número é: " + secondNumber);
        }
    }
}