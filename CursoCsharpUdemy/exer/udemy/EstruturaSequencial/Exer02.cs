using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer02
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.Write("Informe o valor do raio do círculo: ");
            double radius = double.Parse(Console.ReadLine());

            double area = pi * (radius * radius);

            Console.WriteLine($"Resultado: {area}");
        }
    }
}