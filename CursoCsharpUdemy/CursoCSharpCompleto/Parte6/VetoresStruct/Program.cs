﻿namespace Vetores
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }
            
            double soma = 0;
            
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }
            
            double avg = soma / n;
            
            Console.WriteLine("altura Média = " + avg.ToString("F2"));
        }
    }
}