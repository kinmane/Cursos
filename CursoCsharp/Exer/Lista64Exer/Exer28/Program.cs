/*
 * 28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200. 
 */

namespace Exer28
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}