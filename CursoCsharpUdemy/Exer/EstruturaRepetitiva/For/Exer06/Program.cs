﻿namespace Exer06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}