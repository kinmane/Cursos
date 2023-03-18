using System;
using System.Globalization;

namespace parte3
{
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());;

            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine($"Você digitou: {ch}");
        }
    }
}
