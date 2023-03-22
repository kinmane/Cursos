using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte3
{
    public class For
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int value = int.Parse(Console.ReadLine());

                sum += value;
            }

            Console.WriteLine("Soma = " + sum);
        }
    }
}