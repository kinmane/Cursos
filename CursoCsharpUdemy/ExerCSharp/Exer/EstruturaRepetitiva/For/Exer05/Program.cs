﻿namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Digite um número inteiro:");
            number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("O fatorial de " + number + " é " + factorial);
        }
    }
}