namespace Exer06
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangle, circle, trapezium, square, rectangle;

            Console.WriteLine("Digite os valores de A, B e C: ");
            string[] input = Console.ReadLine().Split(' ');
            a = double.Parse(input[0]);
            b = double.Parse(input[1]);
            c = double.Parse(input[2]);
            
            triangle = a * c / 2;
            circle = 3.14159 * Math.Pow(c, 2);
            trapezium = (a + b) * c / 2;
            square = b * b;
            rectangle = a * b;
            
            Console.WriteLine("TRIANGULO: " + triangle.ToString("F2"));
            Console.WriteLine("CIRCULO: " + circle.ToString("F2"));
            Console.WriteLine("TRAPEZIO: " + trapezium.ToString("F2"));
            Console.WriteLine("QUADRADO: " + square.ToString("F2"));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F2"));
        }
    }
}