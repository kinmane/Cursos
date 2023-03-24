using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Primeiro número maior que segundo.");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Segundo número maior que primeiro.");
            }
            else
            {
                Console.WriteLine("São iguais.");
            }
        }
    }
}