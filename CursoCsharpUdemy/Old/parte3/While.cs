using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte3
{
    public class While
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            double number = double.Parse(Console.ReadLine());

            while (number >= 0.0)
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt.ToString("F3"));
                Console.Write("Informe outro número: ");
                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");
        }
    }
}