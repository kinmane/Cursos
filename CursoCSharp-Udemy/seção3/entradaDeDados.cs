using System;
using System.Globalization;

namespace Course
{
    class Program
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
