using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            double c = double.Parse(Console.ReadLine());

            double triangle = a * c / 2.0;
            double circle = 3.14159 * (c * c);
            double trapezoid = (a + b) / 2.0 * c;
            double square = b * b;
            double rectangle = a * b;

            Console.WriteLine("Triangulo: " + triangle.ToString("F2"));
            Console.WriteLine("Circulo: " + circle.ToString("F2"));
            Console.WriteLine("Trapezio: " + trapezoid.ToString("F2"));
            Console.WriteLine("Quadrado: " + square.ToString("F2"));
            Console.WriteLine("Retangulo: " + rectangle.ToString("F2"));
        }
    }
}