﻿namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Informe um valor inteiro: ");
            number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

