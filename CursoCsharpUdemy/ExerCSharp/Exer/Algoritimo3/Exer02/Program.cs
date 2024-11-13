/*
 * 2) Desenvolver um algoritmo que leia a altura de 15 pessoas. 
 * Este programa deverá calcular e mostrar :
 * a. A menor altura do grupo;
 * b. A maior altura do grupo; 
 */

namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double smallestHeight = double.MaxValue;
            double largestHeight = double.MinValue;

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Digite a altura da pessoa " + i + ": ");
                double height = double.Parse(Console.ReadLine());

                if (height < smallestHeight)
                {
                    smallestHeight = height;
                }

                if (height > largestHeight)
                {
                    largestHeight = height;
                }
            }

            Console.WriteLine("Menor altura do grupo: " + smallestHeight.ToString("F2"));
            Console.WriteLine("Maior altura do grupo: " + largestHeight.ToString("F2"));
        }
    }
}