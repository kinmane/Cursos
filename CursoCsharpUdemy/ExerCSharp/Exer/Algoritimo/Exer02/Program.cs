/*
 * 2. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
 * cavalos comprados para um haras. 
 */

namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int horses, horseshoes;
            
            System.Console.Write("Quantos cavalos você comprou? ");
            horses = int.Parse(System.Console.ReadLine());
            
            horseshoes = horses * 4;
            
            System.Console.WriteLine($"Você precisará de {horseshoes} ferraduras.");
        }
    }
}