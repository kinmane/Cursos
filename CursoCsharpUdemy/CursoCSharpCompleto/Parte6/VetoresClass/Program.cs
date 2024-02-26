﻿namespace VetoresClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                
                vect[i] = new Product { Nome = nome, Preco = preco };
            }
            
            double soma = 0;
            
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }
            
            double avg = soma / n;
            
            Console.WriteLine("Preço Médio = " + avg.ToString("F2"));
        }
    }
}